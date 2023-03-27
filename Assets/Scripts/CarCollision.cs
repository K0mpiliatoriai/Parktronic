using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public Health health;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            CarManager.IsGameFailed = true;
        }
    }
}
