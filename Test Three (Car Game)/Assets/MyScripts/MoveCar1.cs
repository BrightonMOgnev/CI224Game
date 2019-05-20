using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar1 : MonoBehaviour {
    public float sideSpeed = 60.0f;
    public float forwardSpeed = 50.0f;
    public Rigidbody rigidBody;
    public Vector3 movement;

 
    void Awake () {
        rigidBody = this.GetComponent<Rigidbody>();
    }

    void Update () {
        movement = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
        //movement = movement.normalized;
    }

    void moveCharacter(Vector3 direction) {
    rigidBody.MovePosition(transform.position + (direction * sideSpeed * Time.deltaTime));
    }

    void FixedUpdate() {
        moveCharacter(movement);
    }

}