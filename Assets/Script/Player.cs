using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public GameObject winCanvas;
    private Rigidbody2D rb;
    private Vector2 move;
    void Start()
    {
        winCanvas.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm với: " + collision.gameObject.name);

        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Vector2 startposition = new Vector2(-13.5f, 1.51f);
            rb.position = startposition;
        }
        //if (collision.gameObject.tag.Equals("Enemy"))
        //{
        //    Destroy(gameObject);
        //}
        if (collision.gameObject.name.Equals("Goal"))
        {
            winCanvas.SetActive(true);
        }
    }
}
