using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction;
    Rigidbody2D rb;
    [SerializeField] float speed = 5;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(DestroyAfterSeconds());
    }
    void Update()
    {
        rb.velocity = direction * speed;
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }

    private IEnumerator DestroyAfterSeconds()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        iDamagable receiver = collision.gameObject.GetComponent<iDamagable>();

        if (receiver != null)
        {
            receiver.TakeDamage();
            Destroy(gameObject);
        }
    }
}
