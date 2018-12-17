using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    private Vector3 vectorSelf;
    public float jumpForce;


    void FixedUpdate()
    {
        Playermovement();
    }

    public void Playermovement()
    {
        vectorSelf.x = Input.GetAxis("Horizontal");
        vectorSelf.z = Input.GetAxis("Vertical");

        transform.Translate(vectorSelf * movementSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
        }
    }
}