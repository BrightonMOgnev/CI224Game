using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButtons : MonoBehaviour
{
    public void NotDoneYet()
    {
        SceneManager.LoadScene(0);
    }

    public void IQuit()
    {
        Application.Quit();
    }

}
