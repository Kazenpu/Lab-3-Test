using System.Runtime.CompilerServices;
using UnityEngine;

public class PrefabEnemy : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    public GameObject prefabObj;
    public GameObject player;
    private GameObject spawnEnemy;

    private int time = 0;
    void Start()
    {

    }


    void Update()
    {
        time++;

        if (time > 500)
        {
            spawnEnemy = Instantiate(prefabObj, transform.position, Quaternion.identity);

            direction = (player.transform.position - spawnEnemy.transform.position).normalized;

            spawnEnemy.GetComponent<Rigidbody2D>().linearVelocity = direction * speed;

            time = 0; //reset lai bo dem
        }
    }
}
