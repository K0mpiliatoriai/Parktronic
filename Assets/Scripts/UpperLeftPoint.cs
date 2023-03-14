using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperLeftPoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger)
        {
            CarManager.UpperLeftPoint = true;
            print("test2");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CarManager.UpperLeftPoint = false;
    }
}
