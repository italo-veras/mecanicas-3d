using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFps : MonoBehaviour
{

    public Transform playerTransform;

    public float mouseSensi;
    public float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensi;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensi;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerTransform.Rotate(Vector3.up * mouseX);
       // mouseMoviment();
    }
    void mouseMoviment()
    {
        

    }
}
