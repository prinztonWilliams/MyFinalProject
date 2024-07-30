using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControlerAlt : MonoBehaviour
{
    [Tooltip("The speed in which the camera will rotate left & right")] public int rotateSpeedX = 300;
    [Tooltip("The speed in which the camera will rotate up & down")] public int rotateSpeedY = 200;
    [SerializeField ,Tooltip("The transform component of the object this will follow")] private Transform target;
    [SerializeField ,Tooltip("The position offset of the camera from its target to determine the distance it keeps from it")] private Vector3 posOffset;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen
        Cursor.visible = false;                   // make the cursor invisible
    }

    private void Update()
    {
        HandleRotation();
    }

    private void LateUpdate()
    {
        HandleMovement();
    }

    private void HandleRotation()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera based on mouse input
        if (mouseX != 0)
        {
            transform.Rotate(0, mouseX * rotateSpeedX * Time.deltaTime, 0, Space.World);
        }

        if (mouseY != 0)
        {
            transform.Rotate(-mouseY * rotateSpeedY * Time.deltaTime, 0, 0, Space.Self);
        }

        // Lock the z-axis rotation
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = 0;
        transform.eulerAngles = currentRotation;
    }

    private void HandleMovement()
    {
        if (target != null)
        {
            transform.position = target.position + posOffset;
        }
    }   
}
