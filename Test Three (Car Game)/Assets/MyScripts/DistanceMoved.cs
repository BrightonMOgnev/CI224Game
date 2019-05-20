using UnityEngine.UI;
using UnityEngine;

public class DistanceMoved : MonoBehaviour
{
    public Transform car;
    public Text distanceText;

    void Update()
    {
        distanceText.text = car.position.z.ToString("0");
    }

}
