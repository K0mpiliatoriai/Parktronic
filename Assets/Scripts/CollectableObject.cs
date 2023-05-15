using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectableObject : MonoBehaviour
{
    public AudioSource collectableSound;
    [SerializeField] public TextMeshProUGUI collectablesText;
    private bool isColliding = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (isColliding) return;
        isColliding = true;

        if (collision.isTrigger)
        {
            Destroy(gameObject);
            CarManager.CollectableCount++;
            collectablesText.text = "Collected: " + CarManager.CollectableCount;
            collectableSound.Play();
        }
        StartCoroutine(Reset());
    }

    IEnumerator Reset()
    {
        yield return new WaitForEndOfFrame();
        isColliding = false;
    }
}
