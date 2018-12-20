using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CivilianMovement : MonoBehaviour 
{
    public List<GameObject> destination = new List<GameObject>();
    public int nowAtDestination;
    public NavMeshAgent agent;

	void Start () 
	{
        agent = GetComponent<NavMeshAgent>();

        destination.AddRange(GameObject.FindGameObjectsWithTag("Destination"));

        nowAtDestination = Random.Range(0, destination.Count);
        agent.SetDestination(destination[nowAtDestination].transform.position);
    }
	

	void Update () 
	{

	}

    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Destination")
        {
            nowAtDestination = Random.Range(0, destination.Count);
            agent.SetDestination(destination[nowAtDestination].transform.position);
        }
    }
}
