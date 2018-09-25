using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    void Update ()
    {
        transform.Translate(0, bulletSpeed, 0 * Time.deltaTime);

        Destroy(gameObject, 3);
	}

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Enemy1")
        {
            gameManager.GetComponent<ScoreCount>().score += 100;
            Destroy(c.gameObject);
            Destroy(gameObject);
        }
    }
}
