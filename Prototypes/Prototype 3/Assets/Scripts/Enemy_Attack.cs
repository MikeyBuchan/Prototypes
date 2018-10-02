using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour 
{
    public GameObject deathPanel;

    void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == "Player")
        {
            deathPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}