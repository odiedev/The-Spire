using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensitivity = 2f;
    public float maxYAngle = 80f;
    public float minYAngle = -80f;
    public float maxXAngle = 360f;
    public float minXAngle = -360f;

    private float rotX = 0f;
    private float rotY = 0f;

    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor to the center of the screen
        Cursor.visible = false; // Hide the cursor
    }

   
    void Update()
    {
        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Update rotation
        rotX -= mouseY;
        rotX = Mathf.Clamp(rotX, minYAngle, maxYAngle); // Limit the vertical rotation
        rotY += mouseX;
        rotY = Mathf.Clamp(rotY, minXAngle, maxXAngle); // Limit the horizontal rotation

        // Apply the rotation
        transform.localRotation = Quaternion.Euler(rotX, rotY, 0f);
    }
}
