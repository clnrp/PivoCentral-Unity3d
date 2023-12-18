using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpDown : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    float verticalRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

    }
}
