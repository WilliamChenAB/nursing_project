using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName, verticalInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController charController;

    private float vertInput, horizInput;
    private Vector3 forwardMovement, strafeMovement;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        movementSpeed = 5;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        vertInput = Input.GetAxis(verticalInputName) * movementSpeed;
        horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

        forwardMovement = transform.forward * vertInput;
        strafeMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + strafeMovement);
    }
}
