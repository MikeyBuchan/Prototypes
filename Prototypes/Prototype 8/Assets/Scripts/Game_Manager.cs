using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour 
{
    public Text infectedText;
    public GameObject civsparent;
    public int amountInfected;
    public List<GameObject> civs;

    void Start () 
	{
        for (int i = 0; i < civsparent.transform.childCount; i++)
        {
            civs.Add(civsparent.transform.GetChild(i).gameObject);
        }
	}
	

	void Update () 
	{
        infectedText.text = "Infected: " + amountInfected.ToString();
    }

    public void InfectedUI()
    {

    }
}
