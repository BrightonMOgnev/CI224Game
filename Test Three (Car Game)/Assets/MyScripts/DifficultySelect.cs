using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelect : MonoBehaviour
{
    public void EasyButton()
    {
        SceneManager.LoadScene(3);
    }

    public void ModerateButton()
    {
        SceneManager.LoadScene(5);
    }

    public void ImpossibleButton()
    {
        SceneManager.LoadScene(7);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
