using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour 
{
    private Transform player_Body;
    public float speed;

	void Start () 
	{
        player_Body = GameObject.FindWithTag("Player").transform;
	}
	

	void FixedUpdate () 
	{
        transform.parent.LookAt(player_Body.position + transform.parent.forward);
        transform.parent.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
