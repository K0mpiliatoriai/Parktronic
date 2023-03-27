using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    

    public HealthBar healthBar;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        healthBar.SetHeath(damage);
    }
}
