using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    //public int points;
    public float Points;
    public GameObject Player = SceneManager.GetSceneByName(Homebase).GetRootGameObject("Player");

    void Awake()
    {

    }

    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerScript playerScript = Player.GetComponent<PlayerScript>();
        Points = playerScript.Points;


    }
}
