using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    [SerializeField] protected int bulletsFired = 1;
    [SerializeField, Range(0f, 10f)] float spread = 1;
    [SerializeField] protected int magazineSize;
    [SerializeField, Range(0.1f, 5f)] protected float rateOfFire = 1;
    [SerializeField] protected ParticleSystem particles;

    private float lastShotTime = 0;

    public virtual void Shoot(Vector2 mousePosition)
    {
        if (!CanShoot())
            return;

        StartCoroutine(CreateBullet(mousePosition.normalized));

        lastShotTime = Time.time;

        if (particles != null)
            particles.Emit(20);
    }

    protected bool CanShoot()
    {
        return Time.time - lastShotTime >= 1 / rateOfFire;
    }

    public virtual void Reload()
    {

    }

    Vector2 Spread(Vector2 dir, float maxSpreadAngle)
    {
        // Generate a random angle within the specified spread angle
        float spreadAngle = Random.Range(-maxSpreadAngle, maxSpreadAngle);

        // Rotate the direction vector by the random angle
        Quaternion rotation = Quaternion.Euler(0, 0, spreadAngle);
        Vector2 spreadDir = rotation * dir;

        return spreadDir;
    }

    IEnumerator CreateBullet(Vector2 dir)
    {
        for (int i = 0; i < bulletsFired; i++)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Vector2 newBulletDirection = Spread(dir, spread);
            newBullet.GetComponent<Bullet>().SetDirection(newBulletDirection);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
