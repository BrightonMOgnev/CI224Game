using UnityEngine;

public class CarCollision1 : MonoBehaviour
{

    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
    }

}
