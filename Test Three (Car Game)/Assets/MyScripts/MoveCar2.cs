using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar2 : MonoBehaviour {
    public Rigidbody rigidBody;
    public float forwardMove = 10000.0f;
    public float sideMove = 1800.0f;


void FixedUpdate() {
    rigidBody.AddForce(0, 0, forwardMove * Time.deltaTime);
    
    if ( Input.GetKey("d") || Input.GetKey("right")) {
        //rigidBody.AddForce(sideMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        rigidBody.AddForce(sideMove * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        
    if ( Input.GetKey("a") || Input.GetKey("left")) {
        //rigidBody.AddForce(-sideMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        rigidBody.AddForce(-sideMove * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        
    if (rigidBody.position.y <-5f){
        FindObjectOfType<GameManager>().GameOver();
        }
        
    }
}