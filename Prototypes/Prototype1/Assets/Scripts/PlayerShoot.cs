using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject barrel;
    public GameObject bullet;

    public float fireRate;
    private bool allowToShoot = true;
	
	
	void Update ()
    {
        if (allowToShoot == true)
        {
            if (Input.GetButtonDown("Jump"))
            {
                StartCoroutine("Shoot");
            }
        }
	}

    public IEnumerator Shoot()
    {
        allowToShoot = false;
        print("shot bullet");
        Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
        yield return new WaitForSeconds(fireRate);
        allowToShoot = true;
    }
}
