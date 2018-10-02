using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour 
{
    public float movementSpeed;
    private Vector3 vectorSelf;
	

	void FixedUpdate () 
	{
        PlayerMovement();
	}

    public void PlayerMovement()
    {
        vectorSelf.x = Input.GetAxis("Horizontal");
        vectorSelf.z = Input.GetAxis("Vertical");

        transform.Translate(vectorSelf * movementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == "Enemy1")
        {
            transform.GetComponent<Player_Shoot>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}