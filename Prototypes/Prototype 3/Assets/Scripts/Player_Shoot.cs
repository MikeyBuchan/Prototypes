using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Shoot : MonoBehaviour 
{
    [SerializeField] private bool allowedToShoot = true;
    private GameObject mainCamera;
    private RaycastHit rayHit;

    public GameObject deathPanel;

    public Text killCounter;
    public int killCount;

	void Start () 
	{
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

            if (rayHit.transform != null && rayHit.transform.tag == "Enemy1")
            {
                print("Hit enemy");
                KillCounterPlusOne();
                print(rayHit.transform.name);
                Destroy(rayHit.transform.gameObject);
            }
            else
            {
                print("Hit Player");
                deathPanel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
            }
        }
    }

    public void KillCounterPlusOne()
    {
        killCount += 1;
        killCounter.text = ("Enemies killed: ") + killCount.ToString();
    }
}