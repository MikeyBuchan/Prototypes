using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour 
{
    [SerializeField] private bool allowedToShoot = true;
    private GameObject gunBarrel;
    private GameObject mainCamera;
    private RaycastHit rayHit;

	void Start () 
	{
        gunBarrel = GameObject.FindGameObjectWithTag("GunBarrel");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	

	void Update () 
	{
        PlayerShoot();
	}

    public void PlayerShoot()
    {
        if (allowedToShoot == true && Input.GetButtonDown("Fire1"))
        {
            Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out rayHit);

            if (rayHit.transform.tag == "Enemy1")
            {
                print(rayHit.transform.name);
            }
        }
    }
}
