using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //This is a reference to the rigidbody component named rigidbody
    public Rigidbody rigidbody;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked it as FixedUpdate because we are going to mess with the physics...
    void FixedUpdate () {
        //Add a forword force
        rigidbody.AddForce(0, 100, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidbody.position.x > 8f || rigidbody.position.x < -8f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
} 
