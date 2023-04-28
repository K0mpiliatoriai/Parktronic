using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightExplotion2 : MonoBehaviour
{
    public ParticleSystem explotionR2;

    private void Start()
    {
        explotionR2.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.isTrigger)
        {
            explotionR2.Play();

        }
    }
}
