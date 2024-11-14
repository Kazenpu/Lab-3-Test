using UnityEngine;

public class RandomUDEnemy : MonoBehaviour
{   
    private float x;
    public float minY = -3f; 
    public float maxY = 3f;  
    public float speed = 2f;
    public float delay;

    private Rigidbody2D rb;
    private Vector2 targetPosition; 
    private float lastMoveTime;
    void Start()
    {
        lastMoveTime = Time.time;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() //Kiem tra vi tri hien tai
    {
        if (Time.time - lastMoveTime >= delay)
        {
            SetRandomTargetPosition();
            lastMoveTime = Time.time;
        }
    }
    private void FixedUpdate() //di chuyen
    {
        rb.position = Vector2.MoveTowards(rb.position, targetPosition, speed);
    }
    void SetRandomTargetPosition() //tao vi tri ngau nhien
    {
        float randomY = Random.Range(minY, maxY);

        targetPosition = new Vector2(x, randomY);
    }
}
