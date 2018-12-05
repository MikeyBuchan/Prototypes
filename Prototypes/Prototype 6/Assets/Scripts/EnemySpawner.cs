using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour 
{
    public float spawnRange;    
    public int spawnAmount;

    public GameObject enemy;

    void Start () 
	{
        spawnEnemies();
	}
	

	void Update () 
	{

	}

    void spawnEnemies()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            Instantiate(enemy,transform.position + new Vector3(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange), 0), Quaternion.identity);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 0) * spawnRange * 2);
    }
}
