using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Target : MonoBehaviour
{
    public float health = 50 ;
    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {

            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    
}
