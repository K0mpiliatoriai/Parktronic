using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperRightPoint : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger)
        {
            CarManager.UpperRightPoint = true;
            print("test2");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CarManager.UpperRightPoint = false;
    }
}
