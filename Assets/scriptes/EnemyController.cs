using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    private int life = 5;


    private void Start()
    {
        Destroy(gameObject, life);
    }

    private void FixedUpdate()
    {
        movement();
    }


    void movement()
    {
        transform.position += transform.right * -speed * Time.fixedDeltaTime;
    }
}
