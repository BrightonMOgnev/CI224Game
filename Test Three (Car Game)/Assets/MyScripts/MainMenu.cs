using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void DifficultySelect()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Changed to this as I have separate scenes for Difficulty and Level Select.
        SceneManager.LoadScene(1);
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(2);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
