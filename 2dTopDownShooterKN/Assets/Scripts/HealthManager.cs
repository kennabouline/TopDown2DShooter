using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private float health;
    public float MaxHealth;
    public Behaviour[] myComponents;
    public bool isPlayer;
    public Image healthBar;

    private void Start()
    {
       
        if (isPlayer)
        {
            health = MaxHealth;

            healthBar.fillAmount = health / MaxHealth;
           
           

        }
        else
        {
            health = Random.value * MaxHealth;
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (isPlayer)
        {
            healthBar.fillAmount = health / MaxHealth;
        }
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
