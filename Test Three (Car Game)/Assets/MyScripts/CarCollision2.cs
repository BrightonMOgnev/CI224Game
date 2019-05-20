using UnityEngine;

public class CarCollision2 : MonoBehaviour
{
    //public MoveCar1 movement.
    public MoveCar2 movement;

    //carBody reffers to police_car_main child of the player's car.
    public Transform carBody;

    //Stores different materials in array to be used when changing player material.
    public Material[] material;

    private float materialDelay = 5f;

    public GameObject[] PoliceArray;

    public GameObject playerCar;

    void Awake ()
    {
        playerCar = GameObject.Find("Car2");

        carBody = this.gameObject.transform.GetChild(0);
        //Sets the default body colour in case of restart.
        carBody.GetComponent<Renderer>().material = material[0];
    }

    void OnCollisionEnter (Collision collisionType)
    {
        Debug.Log(collisionType.collider.tag);

        if(collisionType.collider.tag == "PoliceCar"){
            //Debug.Log("OUCH!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
            }

        if(collisionType.collider.tag == "SmallObject"){
            //Debug.Log("'TIS BUT A SCRATCH!");
            }
        

    }

    void OnTriggerEnter(Collider powerUp)
    {
        if(powerUp.GetComponent<Collider>().tag == "HologramBall"){
            //Changes material to hologram material.
            carBody.GetComponent<Renderer>().material = material[1];
            HologramCar();

            Invoke("defaultMaterial", materialDelay);
            Invoke("defaultCars", materialDelay);
        }

        if(powerUp.GetComponent<Collider>().tag == "ShrinkBall"){
            carBody.GetComponent<Renderer>().material = material[2];
            TinyCar();

            Invoke("defaultMaterial", materialDelay);
            Invoke("defaultSize", materialDelay);
        }
    }

    void defaultMaterial()
    {
        carBody.GetComponent<Renderer>().material = material[0];
    }

    void HologramCar()
    {
        PoliceArray = GameObject.FindGameObjectsWithTag("PoliceCar");
        foreach(GameObject cars in PoliceArray)
        {
            cars.GetComponent<Collider>().enabled = false;
            cars.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    void defaultCars()
    {
        PoliceArray = GameObject.FindGameObjectsWithTag("PoliceCar");
        foreach(GameObject cars in PoliceArray)
        {
            cars.GetComponent<Collider>().enabled = true;
            cars.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    void TinyCar()
    {
        playerCar.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
        playerCar.transform.position -= new Vector3(0.0f, 0.43859f, 0.0f);
        // 0.938572f
    }

    void defaultSize()
    {
        playerCar.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        playerCar.transform.position += new Vector3(0.0f, 0.438595f, 0.0f);
        // 1.377165f
    }
}
