using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    private Vector3 vectorSelf;
    public float movementSpeed;

	void Start () 
	{
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void FixedUpdate ()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        vectorSelf.x = Input.GetAxis("Horizontal");
        vectorSelf.y = Input.GetAxis("Vertical");

        transform.Translate(vectorSelf * movementSpeed * Time.deltaTime);
    }
}
