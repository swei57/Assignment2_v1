using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 100f;
    public float sideForce = 100f;

    //using fixed update for physics, smoother gameplay
    void FixedUpdate () { 
        //adding a forward force to ball
       // rb.AddForce(0, 0, forwardForce * Time.deltaTime); //even outs the frame rates

        if (Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
