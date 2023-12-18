using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 100f;

    Camera m_MainCamera;
    float verticalRotation = 0f;
    float verticalVelocity = 0f;

    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main;
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse movement
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(0f, horizontalRotation, 0f);

        //verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        //m_MainCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Movement
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        float verticalMovement = Input.GetAxis("Vertical") * moveSpeed;

        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        if (characterController.isGrounded && Input.GetButtonDown("Jump"))
        {
            verticalVelocity = 10f;
        }

        Vector3 movement = new Vector3(horizontalMovement, verticalVelocity, verticalMovement);
        movement = transform.rotation * movement;

        characterController.Move(movement * Time.deltaTime);
    }
}
