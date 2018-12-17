using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour 
{
    public GameObject target;
    public GameObject building;
    public Vector3 truePos;
    public float gridSize;
	

	void LateUpdate () 
	{
        truePos.x = Mathf.RoundToInt(target.transform.position.x / gridSize) * gridSize;
        truePos.y = Mathf.RoundToInt(target.transform.position.y / gridSize) * gridSize;
        truePos.z = Mathf.RoundToInt(target.transform.position.z / gridSize) * gridSize;

        building.transform.position = truePos;
    }
}
