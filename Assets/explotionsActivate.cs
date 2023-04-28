using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotionsActivate : MonoBehaviour
{
    public ParticleSystem explotion1;
    public ParticleSystem explotion2;
    public static bool front = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (front == true)
        {
            explotion1.Play();
        }
    }
        
}
