// Initial Code taken from https://sharpcoderblog.com/blog/unity-3d-fps-controller, and modified appropriately

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour {
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    public float runAcceleration = 10f;
    public float runDecceleration = -20f;

    public float walkAcceleration = 5f;
    public float walkDecceleration = -5f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;

    float velocity;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    [HideInInspector]
    public bool canMove = true;

    float curSpeedX = 0;
    float curSpeedY = 0;
    Animator animator;

    public bool shouldUpdate;

    void Start() {
        // characterController = GetComponent<CharacterController>();
        // animator = GetComponent<Animator>();

        // Lock cursor
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;

    }

    void Update() {

    //     if (shouldUpdate) {

    //         if(Input.GetKeyDown("b")) {
    //             animator.SetBool("isDancing", true);
    //         }
            
    //         else if(Input.GetKeyUp("b")) {
    //             animator.SetBool("isDancing", false);
    //         }
            
    //         // Pause game when user presses escape, and returns cursor to normal 
    //         if(Input.GetKeyDown(KeyCode.Escape)) { 
    //             Cursor.lockState = CursorLockMode.None;
    //             Cursor.visible = true;
    //             canMove = false;
    //         }

    //         // When the user left clicks, unpause
    //         if(Input.GetMouseButtonDown(0)) {
    //             canMove = true;
    //             Cursor.lockState = CursorLockMode.Locked;
    //             Cursor.visible = false;
    //         }

    //         if(!canMove) {
    //             // animator.SetFloat("Velocity", 0);
    //             return;  //return out of the function if game is paused
    //         }

    //         // We are grounded, so recalculate move direction based on axes
    //         Vector3 forward = transform.TransformDirection(Vector3.forward);
    //         Vector3 right = transform.TransformDirection(Vector3.right);
    //         // Press Left Shift to run
    //         bool isRunning = Input.GetKey(KeyCode.LeftShift);

    //         // Be able to move inthe XY direction only if on the ground
    //         if((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)) { // moving
    //             if(characterController.isGrounded) {
    //                 if(isRunning) {
    //                     if(velocity < runningSpeed) {
    //                         curSpeedX += runAcceleration * Time.deltaTime * Input.GetAxis("Vertical");
    //                         curSpeedY += runAcceleration * Time.deltaTime * Input.GetAxis("Horizontal");
    //                     }
    //                     else {
    //                         curSpeedX = runningSpeed * Input.GetAxis("Vertical");
    //                         curSpeedY = runningSpeed * Input.GetAxis("Horizontal");
    //                     }
    //                 }
    //                 else {
    //                     if(velocity > walkingSpeed) {
    //                         curSpeedX += runDecceleration * Time.deltaTime * Input.GetAxis("Vertical");
    //                         curSpeedY += runDecceleration * Time.deltaTime * Input.GetAxis("Horizontal");
    //                     }

    //                     else if(velocity < walkingSpeed) {
    //                         curSpeedX += walkAcceleration * Time.deltaTime * Input.GetAxis("Vertical");
    //                         curSpeedY += walkAcceleration * Time.deltaTime * Input.GetAxis("Horizontal");
    //                     }
    //                     else {
    //                         curSpeedX = walkingSpeed * Input.GetAxis("Vertical");
    //                         curSpeedY =  walkingSpeed * Input.GetAxis("Horizontal");
    //                     }
    //                 }
    //             }
    //         }
    //         else { // should stop
    //             Debug.Log("tryuing to stop");

    //                 if(curSpeedX > 0) {
    //                     curSpeedX += (runDecceleration * Time.deltaTime);
    //                 }
    //                 else {
    //                     curSpeedX = 0;
    //                 }

    //                 if(curSpeedY > 0) {
    //                     curSpeedY += (runDecceleration * Time.deltaTime);
    //                 }
    //                 else {
    //                     curSpeedY = 0;
    //                 }
    //         }

    //         if(velocity == 0 && Input.GetKey("b")) {
    //             animator.SetBool("isDancing", true);
    //         }
    //         else {
    //             animator.SetBool("isDancing", false);
    //         }

            
    //         float movementDirectionY = moveDirection.y;
    //         moveDirection = (forward * curSpeedX) + (right * curSpeedY);

    //         if (Input.GetButton("Jump") && characterController.isGrounded) {
    //             moveDirection.y = jumpSpeed;
    //         }
    //         else {
    //             moveDirection.y = movementDirectionY;
    //         }

    //         velocity = Mathf.Sqrt(moveDirection.x * moveDirection.x + moveDirection.z * moveDirection.z);
    //         animator.SetFloat("Velocity", velocity);

    //         if (!characterController.isGrounded) {
    //             moveDirection.y -= gravity * Time.deltaTime;
    //         }

    //         // Move the controller
    //         characterController.Move(moveDirection * Time.deltaTime);

    //         // Player and Camera rotation
    //         if (canMove) {
    //             rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
    //             rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
    //             playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    //             transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    //         }
    //     }
    }
}