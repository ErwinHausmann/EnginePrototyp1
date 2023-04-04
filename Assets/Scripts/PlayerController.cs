using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 3;
    public float jumpForce;

    public Animator animator;

    // camera and rotation
    public Transform cameraHolder;
    public Transform cameraHolderFP;
    public float mouseSensitivity = 2f;
    public float upLimit = -50;
    public float downLimit = 50;

    // gravity
    private float gravity = 9.87f;
    private float verticalSpeed = 0;

    void Update()
    {
        Move();
        Rotate();
    }

    private void Awake()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    public void Rotate()
    {
        float horizontalRotation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalRotation * mouseSensitivity, 0);
        cameraHolder.Rotate(-verticalRotation * mouseSensitivity, 0, 0);
        cameraHolderFP.Rotate(-verticalRotation * mouseSensitivity, 0, 0);

        Vector3 currentRotation = cameraHolder.localEulerAngles;
        if (currentRotation.x > 180) currentRotation.x -= 360;
        currentRotation.x = Mathf.Clamp(currentRotation.x, upLimit, downLimit);
        cameraHolder.localRotation = Quaternion.Euler(currentRotation);

        Vector3 currentRotationFP = cameraHolderFP.localEulerAngles;
        if (currentRotationFP.x > 180) currentRotationFP.x -= 360;
        currentRotationFP.x = Mathf.Clamp(currentRotationFP.x, upLimit, downLimit);
        cameraHolderFP.localRotation = Quaternion.Euler(currentRotationFP);
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (characterController.isGrounded) {
            verticalSpeed = 0;
            
            if (Input.GetButtonDown("Jump")) {
                verticalSpeed = jumpForce;
            }
            if (Input.GetButton("Jump")) {
                verticalSpeed = jumpForce;
            }
        }

        else verticalSpeed -= gravity * Time.deltaTime;
        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0);

        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        characterController.Move(speed * Time.deltaTime * move + gravityMove * Time.deltaTime);

        animator.SetBool("isWalking", verticalMove != 0 || horizontalMove != 0);
        animator.SetBool("isJumping", verticalSpeed > 0);
    }
}
