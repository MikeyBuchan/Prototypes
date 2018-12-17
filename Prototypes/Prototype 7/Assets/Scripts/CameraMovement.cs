using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity;

    public GameObject selectWheel;
    public bool uiActive;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Cameramovement();
        UIWheel();
    }

    public void Cameramovement()
    {
        transform.parent.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * sensitivity * Time.deltaTime);
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0) * sensitivity * Time.deltaTime);
    }

    void UIWheel()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            uiActive = !uiActive;
        }

        if (uiActive == true)
        {
            selectWheel.active = uiActive;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (uiActive == false)
        {
            selectWheel.active = uiActive;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}