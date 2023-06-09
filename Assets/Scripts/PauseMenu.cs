using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	[SerializeField] GameObject pauseMenu;

	// Pause the game
	public void Pause () {
		pauseMenu.SetActive (true);
		Time.timeScale = 0;
	}
	
	// Resume the game
	public void Resume () {
		pauseMenu.SetActive (false);
		Time.timeScale = 1;
	}
	public void Home(int SceneID) {
		Time.timeScale = 1;
        SceneManager.LoadScene(SceneID);
        // kol homescreen nera, unpausina
        //SceneManager.LoadScene (Level1); // SceneID is for homescreen
    }
}
