using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0;

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity ;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity ;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
   
}
