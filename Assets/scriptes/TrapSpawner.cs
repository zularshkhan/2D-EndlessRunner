using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public GameObject[] prefab;
    public float TimeBetweenSpawn;
    private float TimeToSpawn;
    private float speed = 5;
    private float speedIncrement = 1f;



    private void Update()
    {
        if (Time.time >= TimeToSpawn)
        {
            int index = Random.Range(0, prefab.Length);
            spawner(index);
            TimeToSpawn = Time.time + TimeBetweenSpawn;
            if(TimeBetweenSpawn>=1f)
                TimeBetweenSpawn -= 0.1f;
        }
        
    }

    void spawner(int index)
    {
       GameObject TempObject = Instantiate(prefab[index], transform.position, Quaternion.identity);
       TempObject.GetComponent<EnemyController>().speed = speed;
        speed += speedIncrement;
    }
}
