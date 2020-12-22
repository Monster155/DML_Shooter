using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100;
    public Transform playerTransform;
    private float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //camera
        float xMouse = Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        float yMouse = Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;

        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerTransform.Rotate(Vector3.up * xMouse);
    }
}