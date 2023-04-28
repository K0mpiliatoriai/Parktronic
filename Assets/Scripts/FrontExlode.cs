using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontExlode : MonoBehaviour
{
    public ParticleSystem explotionF;

    private void Start()
    {
        explotionF.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" &&  collision.isTrigger)
        {
            explotionF.Play();

        }
    }

}
