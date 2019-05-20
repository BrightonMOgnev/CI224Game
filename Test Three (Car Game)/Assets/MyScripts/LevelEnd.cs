using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.LevelFinished();
    }
}
