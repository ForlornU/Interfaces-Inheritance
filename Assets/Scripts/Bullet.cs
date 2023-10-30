using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 direction;
    Rigidbody2D rb;
    [SerializeField] float speed = 5;

    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = direction * speed;
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir;
    }
}
