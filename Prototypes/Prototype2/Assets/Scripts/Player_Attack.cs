using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Attack : MonoBehaviour 
{
    public Text scoreText;
    public int scoreExtra;

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            scoreExtra += 10;
            print("Killed Enemy");
            Destroy(c.gameObject);
            scoreText.text = scoreExtra.ToString();
        }
    }
}
