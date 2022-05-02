using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform playerBody;

    private float mouseX, mouseY;
    private float xAxisClamp;

    private void Awake()
    {
        //lockCursor();
        xAxisClamp = 0;
    }

    private void lockCursor()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        mouseX = Input.GetAxisRaw(mouseXInputName) * mouseSensitivity;
        mouseY = Input.GetAxisRaw(mouseYInputName) * mouseSensitivity;

        xAxisClamp += mouseY;

        // keeps relative rotation at 0 to simulate a hard stop
        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotation(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotation(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    // Clamps camera to avoid virtual broken necks
    private void ClampXAxisRotation(float angle)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = angle;
        transform.eulerAngles = eulerRotation;
    }
}