using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lethal : MonoBehaviour
{

    public float damage;
    public string enemyTag;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(enemyTag))
        {
            other.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}
