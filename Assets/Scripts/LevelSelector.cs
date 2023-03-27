using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public void OpenScene()
    {
        SceneManager.LoadScene("Level" + level);
    }
    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
