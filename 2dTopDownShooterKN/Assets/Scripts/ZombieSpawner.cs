using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    public GameObject zombiePrefab;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);

    }

    public Vector3 RandomCircle(Vector3 center, float radius)
    {
        float angle = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(angle * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
        pos.z = center.z;

        return pos;
    
    }

    public void Spawn()
    {
        Instantiate(zombiePrefab, RandomCircle(Vector3.zero, 20), Quaternion.identity);
    }

}
