using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour 
{
    public GameObject enemy;
    public List<GameObject> spawnLocations;
    public float spawnTimer;

	void Start () 
	{
        StartCoroutine("SpawnTimer");
	}
	

	void Update () 
	{
		
	}

    public IEnumerator SpawnTimer ()
    {
        print("Line 1");
        Instantiate(enemy, spawnLocations[Random.RandomRange(0,12)].transform);


        yield return new WaitForSeconds(spawnTimer);
        StartCoroutine("SpawnTimer");
    }
}
