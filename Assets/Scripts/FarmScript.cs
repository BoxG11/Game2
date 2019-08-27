using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FarmScript : MonoBehaviour
{
    public bool Inside = false;
    public Text Text;
    public float Points;

    private void OnTriggerEnter(Collider other)
    {
        Inside = true;
        Debug.Log(other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Inside = false;
        Debug.Log("left");
    }
    void Update()
    {
        if(Inside == true)
        {
            Points += Time.deltaTime;
            int points = Convert.ToInt32(Points);
            Text.text = points.ToString() + "$";

            GameObject Player = GameObject.Find("Player");
            PlayerScript playerScript = Player.GetComponent<PlayerScript>();
            playerScript.Points = Points;
        }

    }
}
