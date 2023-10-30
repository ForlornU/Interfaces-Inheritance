using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    int magazineSize;
    int rateOfFire;

    public virtual void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(MousePos().normalized);
    }

    Vector2 MousePos()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePosition - new Vector2(transform.position.x, transform.position.y);
    }

    public virtual void Reload()
    {

    }
}
