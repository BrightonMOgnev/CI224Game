using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameIsOver = false;
    public float deathDelay = 1f;
    private float fasterDelay = 0f;
    public GameObject levelFinishedUI;

    public void LevelFinished ()
    {
        levelFinishedUI.SetActive(true);
    }

    public void GameOver ()
    {
        if (gameIsOver == false){
            gameIsOver = true;
            Invoke("Restart", deathDelay);
            }
    }

    public void GameRestart () 
    {
        if (gameIsOver == false){
            gameIsOver = true;
            Invoke("Restart", fasterDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
