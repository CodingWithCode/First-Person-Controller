using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Moement : MonoBehaviour
{
    public float speed = 12f;
    public float normalSpeed = 12f;
    public float sprintSpeed = 12f;
    public float accelaration = 10f;
    Vector3 moveDirection;
    public CharacterController controller;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3f;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0){
            velocity.y = -2;
        } 
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
       float horizontal = Input.GetAxis("Horizontal"); 
       float vertical = Input.GetAxis("Vertical");
        moveDirection = transform.right * horizontal + transform.forward * vertical;
        controller.Move(moveDirection * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftShift)){
            speed = Mathf.Lerp(speed, sprintSpeed, accelaration);
        } else {
            speed = Mathf.Lerp(speed, normalSpeed, accelaration);
        }
    }
}