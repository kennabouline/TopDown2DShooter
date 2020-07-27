using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float health;
    public Behaviour[] myComponents;
    public bool isPlayer;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    public void Die()
    {
        if (isPlayer)
        {
            foreach (var item in myComponents)
            {
                item.enabled = false;
            }
        }
        else
        {
            Destroy(gameObject);
        }

       
    }

}
