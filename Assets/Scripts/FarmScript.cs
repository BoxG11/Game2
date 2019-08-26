using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FarmScript : MonoBehaviour
{
    public float Points = 0;
    public bool Inside = false;
    public Text Text;
    void OnTriggerStay(Collider other)
    {
        Inside = true;
        Points+= Time.deltaTime;
        int vOut = Convert.ToInt32(Points);
        Text.text = vOut.ToString() + "$";
    }

    void OnTriggerExit(Collider other)
    {
        Inside = false;
    }
}
