using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Vector2 movementVector;
	

	void FixedUpdate ()
    {
        movementVector.x = Input.GetAxis("Horizontal");

        transform.Translate(movementVector * speed * Time.deltaTime);
	}
}
