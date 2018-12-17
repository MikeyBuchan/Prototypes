using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Builder : MonoBehaviour 
{
    GameObject mainCamera;
    RaycastHit rayHit;
    public LayerMask raycastLayer;

    public bool readyToPlace;

    public GameObject selectWheel;
    private bool uiActive;

    [Header("Grid")]
    public GameObject building;
    Vector3 gridPos;
    public float gridSize;

    [Header("Structure")]
    public GameObject previewObject;
    public List<GameObject> structures;
    public int selectedStructureInList;
    public float buildingRange;
    public Material previewMat;
    private bool oneTimeSpawn = true;  //This bool is so it doesn't instantiate the previewObject multiple times

    #region StartAndUpdate
    void Start () 
	{
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	

	void Update () 
	{
        Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward,out rayHit, buildingRange,raycastLayer, QueryTriggerInteraction.Ignore);
        Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward, Color.blue);

        SelectedObjectPreview();
	}
    #endregion

    void LateUpdate()
    {
        gridPos.x = Mathf.RoundToInt(rayHit.point.x / gridSize) * gridSize;
        gridPos.y = Mathf.RoundToInt(rayHit.point.y / gridSize) * gridSize;
        gridPos.z = Mathf.RoundToInt(rayHit.point.z / gridSize) * gridSize;

        building.transform.position = gridPos;
    }

    void SelectedObjectPreview()
    {
        //The toggle for placing preview
        if (Input.GetButtonDown("Fire2"))
        {
            readyToPlace = !readyToPlace;
        }

        //The placing part
        if (readyToPlace == true)
        {
            if (rayHit.transform != null)
            {
                //To check if the player is looking at the ground
                if (rayHit.transform.tag == "Ground" && rayHit.transform != null)
                {
                    if (oneTimeSpawn == true)
                    {
                        previewObject = Instantiate(structures[selectedStructureInList], rayHit.point, Quaternion.identity);
                        previewObject.GetComponent<Renderer>().material = previewMat;
                        building = previewObject;
                        previewObject.GetComponent<BoxCollider>().enabled = false;
                        oneTimeSpawn = false;
                    }
                    else
                    {
                        building = structures[selectedStructureInList];
                        previewObject.transform.position = gridPos;
                    }

                    if (Input.GetButtonDown("Fire1"))
                    {
                        building = previewObject;
                        Instantiate(structures[selectedStructureInList], gridPos, Quaternion.identity);
                    }
                }
            }
        }
        else if (readyToPlace == false)
        {
            Destroy(previewObject);
            oneTimeSpawn = true;
        }
    }

    public void SetBuilding(int index)
    {
        selectedStructureInList = index;

        previewObject = Instantiate(structures[selectedStructureInList], rayHit.point, Quaternion.identity);
        previewObject.GetComponent<Renderer>().material = previewMat;
    }
}
