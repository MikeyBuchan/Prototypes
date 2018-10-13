using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour 
{
    public Rigidbody rb;
    public float speed;
    public float steeringSpeed;

	void Start () 
	{
        rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () 
	{
        CarMovement();
    }

public void CarMovement()
    {
        if (Input.GetButton("W"))
        {
            rb.AddForce(transform.forward * speed * Time.fixedDeltaTime);
        }

        if (Input.GetButton("A"))
        {
            transform.Rotate(0, -steeringSpeed, 0 * Time.fixedDeltaTime);
        }

        if (Input.GetButton("S"))
        {
            rb.AddForce(-transform.forward * speed * Time.fixedDeltaTime);
        }

        if (Input.GetButton("D"))
        {
            transform.Rotate(0, steeringSpeed, 0 * Time.fixedDeltaTime);
        }
    }
}