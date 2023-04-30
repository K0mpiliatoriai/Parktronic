using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScenes : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicobj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicobj.Length > 1)
        {
            Destroy(musicobj[0]);
        }
    }
}
