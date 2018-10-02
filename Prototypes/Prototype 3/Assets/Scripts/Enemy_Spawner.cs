using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour 
{
    public List<GameObject> spawnLocations;
    public GameObject enemy1;
    public float spawnDelay;
    public GameObject deathPanel;

    void Start ()
    {
        StartCoroutine(SpawnTimer());
    }
    

    public IEnumerator SpawnTimer()
    {
        GameObject g = Instantiate(enemy1, spawnLocations[Random.Range(0,spawnLocations.Capacity)].transform.position, enemy1.transform.rotation);
        g.GetComponent<Enemy_Attack>().deathPanel = deathPanel;

        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnTimer());
    }
}
