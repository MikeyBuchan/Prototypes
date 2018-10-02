using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Movement : MonoBehaviour 
{
    public NavMeshAgent agent;
    public Transform target;

	void Start () 
	{
        agent = agent.GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	

	void Update () 
	{
        agent.SetDestination(target.position);
	}
}
