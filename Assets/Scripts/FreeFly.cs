using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeFly : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 100f;

    private float pitch = 0f;
    private float yaw = 0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float up = Input.GetAxis("Fly");
        float down = Input.GetAxis("Fall");

        transform.Translate(Vector3.forward * vertical * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.up * up * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.down * down * Time.deltaTime * movementSpeed);

        yaw += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
