using UnityEngine;

public class UpDownEnemy : MonoBehaviour
{
    public float speed = 2f;
    public float range = 2f;
    private Rigidbody2D rb;
    private bool moveup;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveup = Random.value > 2f;
    }

    void Update()
    {
        if (moveup && rb.position.y >= range)
        {
            moveup = false;
        }
        else if (!moveup && rb.position.y <= -range)
        {
            moveup = true;
        }
    }
    void FixedUpdate()
    {
        if (moveup)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, speed);
        }
        else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -speed);
        }
    }
}
