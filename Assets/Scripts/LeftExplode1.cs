using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftExplode1 : MonoBehaviour
{
    public ParticleSystem explotionL1;

    private void Start()
    {
        explotionL1.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.isTrigger)
        {
            explotionL1.Play();

        }
    }
}
