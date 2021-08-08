using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float Speed = 700.0f;
    public Transform playerBody;
    float xRotation = 0f;
    public GameObject Paused;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        if (!Paused.active)
        {
            float mouseX = Input.GetAxis("Mouse X") * Speed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * Speed * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        
    }
}
