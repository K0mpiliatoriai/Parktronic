using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackExplode : MonoBehaviour
{
    public ParticleSystem explotionB;

    private void Start()
    {
        explotionB.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.isTrigger)
        {
            explotionB.Play();

        }
    }
}
