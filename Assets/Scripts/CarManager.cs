using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public static bool IsGameFailed;
    public GameObject gameFailedScreen;
    public GameObject gameWonScreen;
    public GameObject healthBar;
    public GameObject pauseButton;
    public static bool LowerRightPoint;
    public static bool UpperLeftPoint;
    public static bool UpperRightPoint;
    public static bool LowerLeftPoint;

    private void Awake()
    {
        IsGameFailed= false;
        LowerLeftPoint = false;
        UpperLeftPoint = false;
        LowerRightPoint = false;
        UpperRightPoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsGameFailed)
        {
            Time.timeScale = 0;
            gameFailedScreen.SetActive(true);
            healthBar.SetActive(false);
            pauseButton.SetActive(false);
        }
        else if (LowerLeftPoint && UpperLeftPoint && LowerRightPoint && UpperRightPoint)
        {
            Time.timeScale = 0;
            gameWonScreen.SetActive(true);
            healthBar.SetActive(false);
            pauseButton.SetActive(false);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        gameWonScreen.SetActive(false);
        healthBar.SetActive(false);
        pauseButton.SetActive(false);
    }
}
