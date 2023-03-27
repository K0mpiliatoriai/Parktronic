using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger)
        {
            CarManager.IsGameFailed = true;
        }
    }
}
