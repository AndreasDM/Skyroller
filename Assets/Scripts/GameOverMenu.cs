using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    public GameObject GameOverMenuUI;

    public void ShowMenu()
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        GameOverMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
