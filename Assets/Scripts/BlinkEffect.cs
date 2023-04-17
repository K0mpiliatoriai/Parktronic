using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkEffect : MonoBehaviour
{
    public Color startColor = Color.white;
    public Color endColor = Color.grey;
    [Range(0, 10)]
    public float speed = 1;
    Image imgComp;
    void Awake()
    {
        imgComp = GetComponent<Image>();
    }
    void Update()
    {
        imgComp.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
