using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioSource crashSound;

    public HealthBar healthBar;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            TakeDamage(1);
            crashSound.Play();
        }
    }

    public void TakeDamage(int damage)
    {
        healthBar.SetHeath(damage);
    }
}
