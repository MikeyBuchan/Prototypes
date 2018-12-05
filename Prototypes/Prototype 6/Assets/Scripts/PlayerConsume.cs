using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConsume : MonoBehaviour 
{
    public float playerSize;
    public float startCameraWidth;
    public float widthCameraMulti;
    public float biggenAmount;
    public float movementOnEat;
    public GameObject playerTrail;
    public GameObject camera;


    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            playerSize += biggenAmount;
            transform.localScale = new Vector3(playerSize, playerSize, 0);
            playerTrail.GetComponent<TrailRenderer>().startWidth += biggenAmount;
            playerTrail.GetComponent<TrailRenderer>().time += biggenAmount / 8;
            GetComponent<PlayerMovement>().movementSpeed += movementOnEat;
            Destroy(c.gameObject);

            if (playerSize > startCameraWidth)
            {
                camera.GetComponent<Camera>().orthographicSize += widthCameraMulti;
            }
        }
    }
}
