using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour 
{
    public float speed;
    private Vector2 mv;

	

	void FixedUpdate () 
	{
        mv.x = Input.GetAxis("Horizontal");
        mv.y = Input.GetAxis("Vertical");

        transform.Translate(mv * speed * Time.deltaTime,Space.World);

        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
