using UnityEngine;

public class LeftRightEnemy : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float range = 2f;
    private bool moveright;

    void Start()
    {
        moveright = Random.value > 0.5f;
    }

    void Update()
    {
        if (moveright && transform.position.x >= range)
        {
            moveright = false;
        }
        else if (!moveright && transform.position.x <= -range)
        {
            moveright = true;
        }
    }
    void FixedUpdate()
    {
        if (moveright)
        {
            transform.position += Vector3.right * moveSpeed * Time.fixedDeltaTime;
        }
        else
        {
            transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        }
    }
}
