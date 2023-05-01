using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectableObject : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI collectablesText;
    public int Value;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger)
        {
            Destroy(gameObject);
            CarManager.CollectableCount+=Value;
            collectablesText.text = "Wrenches: " + CarManager.CollectableCount;
        }
    }
}
