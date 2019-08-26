using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.ComponentModel;
using System.Data;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb1;

    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Wall"))
        {
            rb1.angularVelocity = Vector3.zero;
            rb1.velocity = Vector3.zero;
        }
    }
}
