using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour 
{
    void OnTriggerStay2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy" && Input.GetButtonDown("Fire1"))
        {
            print("Killed Enemy");
            Destroy(c.gameObject);
        }
    }
}
