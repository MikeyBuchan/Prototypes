using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfecting : MonoBehaviour 
{
    public GameObject gameManager;
    public Material sickColor;
    GameObject playerCam;
    RaycastHit rayHit;
    public float coughDistance;
    public bool canCough = true;
    public float coughReload;
    public GameObject particle;
    public GameObject coughLoc;

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
                rayHit.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material = sickColor;
                Instantiate(particle, coughLoc.transform.position, Quaternion.identity);
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
