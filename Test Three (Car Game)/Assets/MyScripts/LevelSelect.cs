using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{

    public void LevelOne()
    {
        SceneManager.LoadScene(3);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene(4);
    }

    public void LevelThree()
    {
        SceneManager.LoadScene(5);
    }

    public void LevelFour()
    {
        SceneManager.LoadScene(6);
    }

    public void LevelFive()
    {
        SceneManager.LoadScene(7);
    }
    
    public void LevelSix()
    {
        SceneManager.LoadScene(8);
    }

    public void MenuPlease()
    {
        SceneManager.LoadScene(0);
    }

}
