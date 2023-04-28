using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftExplode2 : MonoBehaviour
{
    public ParticleSystem explotionL2;

    private void Start()
    {
        explotionL2.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.isTrigger)
        {
            explotionL2.Play();

        }
    }
}
