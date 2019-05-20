using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gamePaused){
                Resume();
            }
            else {
                Pause();
            }
        }
        
        
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void GetMenu() {
        SceneManager.LoadScene("AaMainMenu");
        Time.timeScale = 1f;
    }

    public void Restart() {
        Resume();
        FindObjectOfType<GameManager>().GameRestart();
    }

    public void IQuit() {
        Application.Quit();
    }

}
