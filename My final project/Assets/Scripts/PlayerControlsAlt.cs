using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsAlt : MonoBehaviour
{
    private CharacterController controller;
    private Animator animator;

    public float moveSpeed = 5f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xInput, 0, zInput);

        controller.Move(movement * moveSpeed * Time.deltaTime);

        if(controller.isGrounded)
        {
            Debug.Log("GROUNDED");
        }
    }
}
