using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    public Zombie[] gameObjects;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            DestroyZombies();
        }
    }
    public void DestroyZombies()
    {

        gameObjects = FindObjectsOfType<Zombie>();
        foreach (Zombie target in gameObjects)
        {
            Destroy(target.gameObject);
        }



    }
}
