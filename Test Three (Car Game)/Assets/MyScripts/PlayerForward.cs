using UnityEngine;
using System.Collections;

public class PlayerForward : MonoBehaviour
{

public Rigidbody rigidBody;
public float forwardSpeed;
public float sideSpeed;
//Change speeds to private and set them to a given value.
//Vector3 sideVector = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0).normalized;

    // Wake starts before start.
    void Wake()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.forward * forwardSpeed;
        //Set drag to zero so velocity not impacted.
        //Vector3 sideVector = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0).normalized;
        //rigidBody.MovePosition(transform.position + sideVector * Time.deltaTime);
    }

    // FixedUpdate not frame dependant.
    void FixedUpdate()
    {
        //Vector3 instead of transform.
        //Although player object doesn't move in direction they are facing,
        //This doesn't impact the way you need to control the player object after a collision.
        //Therefore making the game easier to master, at the cost of full realism. 
        
        //transform.position += Vector3.forward * Time.deltaTime * forwardSpeed;
        //Every update resets the velocity, keeping it more or less constant. 
        //rigidBody.velocity = Vector3.forward * Time.deltaTime * forwardSpeed;

        //rigidBody.AddForce(Vector3.forward * Time.deltaTime * forwardSpeed);


        if (Input.GetKey("d") || Input.GetKey("right")) {
            //rigidBody.AddForce(Vector3.right * Time.deltaTime * sideSpeed);
        }

        if (Input.GetKey("a") || Input.GetKey("left")) {
            //rigidBody.AddForce(Vector3.left * Time.deltaTime * sideSpeed);
            //rigidBody.velocity = Vector3.left * Time.deltaTime * sideSpeed;
        }

        float moveHorizontally = Input.GetAxis ("Horizontal");

        Vector3 movement = new Vector3 (moveHorizontally, 0.0f, 0.0f).normalized;
        GetComponent<Rigidbody>().velocity = movement * Time.deltaTime * sideSpeed;
    }

}
