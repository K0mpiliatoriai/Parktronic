using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightExplode1 : MonoBehaviour
{
    public ParticleSystem explotionR1;

    private void Start()
    {
        explotionR1.Stop();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" && collision.isTrigger)
        {
            explotionR1.Play();

        }
    }

}
