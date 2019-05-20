using UnityEngine;

public class WatchPlayer1 : MonoBehaviour
{

    public Transform player1;
    public Vector3 offset1;


    void Update()
    {
        transform.position = player1.position + offset1;
    }
}
