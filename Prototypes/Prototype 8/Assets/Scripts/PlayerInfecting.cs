using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfecting : MonoBehaviour 
{
    GameObject playerCam;
    RaycastHit rayHit;
    public float coughDistance;
    public bool canCough = true;
    public float coughReload;

	void Start () 
	{
        playerCam = GameObject.FindGameObjectWithTag("MainCamera");
	}
	

	void Update () 
	{
        SickeningPeople();
	}
    
    public void SickeningPeople()
    {
        Debug.DrawRay(playerCam.transform.position, playerCam.transform.forward,Color.red);

        if(Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out rayHit, coughDistance))
        {
            if (canCough == true && Input.GetButtonDown("Fire1") && rayHit.transform.tag == "Civilian")
            {
                StartCoroutine(CoughReload());
                rayHit.transform.GetComponent<Sick>().isSick = true;
            }
        }
    }

    public IEnumerator CoughReload()
    {
        canCough = false;
        yield return new WaitForSeconds(coughReload);
        canCough = true;
    }
}
