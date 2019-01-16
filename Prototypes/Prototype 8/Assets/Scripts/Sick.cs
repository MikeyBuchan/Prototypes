using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sick : MonoBehaviour 
{
    public bool isSick = false;
    public bool canUp = true;
    public GameObject gameManager;

    void Start () 
	{
        gameManager = GameObject.FindGameObjectWithTag("GameManager");

    }
	

	void Update ()
    {
        if(isSick == true & canUp == true)
        {
            gameManager.GetComponent<Game_Manager>().amountInfected += 1;
            canUp = false;
        }
    }
}
