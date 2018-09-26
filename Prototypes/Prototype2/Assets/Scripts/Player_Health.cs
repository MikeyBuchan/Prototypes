using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour 
{
    public int playerHealth;
    public int damageDoneByEnemy;



	void Update () 
	{
		if (playerHealth <= 0)
        {
            print("Died");
            Time.timeScale = 0;
        }
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            print("Damaged");
            Destroy(c.gameObject);
            playerHealth -= damageDoneByEnemy;
        }
    }
}
