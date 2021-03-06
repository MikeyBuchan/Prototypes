﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Cameramovement();
    }

    public void Cameramovement()
    {
        transform.parent.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * sensitivity * Time.deltaTime);
        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y"), 0, 0) * sensitivity * Time.deltaTime);
    }
}