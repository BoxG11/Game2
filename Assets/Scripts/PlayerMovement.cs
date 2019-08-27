using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.ComponentModel;
using System.Data;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb1;
    public float Speed = 1000f;
    public float tiltSpeed = 90.0f;
    public float JumpSpeed = 5.0f;
    public Vector3 PlayerLocation;
    public bool Collision = false;

    // Start is called before the first frame update
    void FixedUpdate()
    {

        PlayerLocation = rb1.position;

        #region [inputs]

        if (Input.GetKey("w"))
        {
            rb1.AddForce(0, 0, Speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb1.AddForce(0, 0, Speed * -1 * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb1.AddForce(Speed * -1 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb1.AddForce(Speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("space"))
        {
            rb1.AddForce(0, 4.5f, 0);
        }
        #endregion


    }
    
    
}
