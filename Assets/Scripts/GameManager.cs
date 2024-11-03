using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject car;

    private void Start()
    {
    Time.timeScale = 0;
    startScreen.SetActive(true);
    winScreen.SetActive(false); // Ensure winScreen is off
    loseScreen.SetActive(false); // Ensure loseScreen is off
    }

    public void StartGame()
    {
        Time.timeScale = 1; // Resume game
        startScreen.SetActive(false); // Hide start screen
    }

    public void WinGame()
    {
        Time.timeScale = 0; // Pause game
        winScreen.SetActive(true); // Show win screen
    }

    public void LoseGame()
    {
        Time.timeScale = 0; // Pause game
        loseScreen.SetActive(true); // Show lose screen
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload scene
    }
}
