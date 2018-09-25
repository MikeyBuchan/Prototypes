using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    [Header("End texts")]
    public GameObject endPanel;
    public GameObject winPanel;

    [Header("On wall hit")]
    public float goDownBy;


    public List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            enemies.Add(transform.GetChild(i).gameObject);
        }
    }

    void Update()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                print(enemies[i]);
                enemies.Remove(enemies[i]);
            }

            if (enemies.Count == 0)
            {
                print("List is empty");
                winPanel.SetActive(true);
                Time.timeScale = 0;
                break;
            }
        }
    }

    void FixedUpdate ()
    {
        transform.Translate(speed, 0, 0 * Time.deltaTime);
	}

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.transform.tag == "Wall1")
        {
            /*
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] == null)
                {
                    print(enemies[i]);
                    enemies.Remove(enemies[i]);
                }
            }

            if (enemies.Count == 0)
            {
                print("List is empty");
            }
            */

            print("Hit Wall");
            speed = speed - (speed * 2);
            transform.position = new Vector2(transform.position.x, transform.position.y - goDownBy);
        }

        if (c.transform.tag == "EndWall")
        {
            print("Hit end wall");
            endPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
