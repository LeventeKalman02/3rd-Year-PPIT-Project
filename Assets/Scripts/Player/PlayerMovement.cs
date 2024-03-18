using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movement;
    private Vector2 lastMoveDirection;

    private Animator animator;

    public Transform Aim;
    private bool isWalking = false;

    private void Awake()
    {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
        //get animator component
        animator = GetComponent<Animator>();
    }

    //used for inputs and timers
    private void Update()
    {
        MovementAnimation();
    }

    //called once per physics frame - used for Physics
    private void FixedUpdate()
    {
        //call functions in FixedUpdate that do physics calculations
        Movement();
        AimRotation();
    }

    //function controlling the movements of the player
    private void Movement()
    {
        //store last move direction
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //if player stops moving save last move direction
        if ((moveX == 0 && moveY == 0 ) && (movement.x != 0 || movement.y != 0))
        {
            //attack in the last direction that was moved if the player stops
            isWalking = false;
            lastMoveDirection = movement;
            Vector3 vector3 = Vector3.left * lastMoveDirection.x + Vector3.down * lastMoveDirection.y;
            Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
        }
        //if the player is walking, attack in the direction that it is moving
        else if (movement.x != 0 || movement.y != 0)
        {
            isWalking = true;
        }

        //get x and y directions
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //makes the diagonal movement the same as the other movement, otherwise it would be faster
        movement.Normalize();
        rb.velocity = movement * moveSpeed;
    }

    //set the rotation of the melee aim cone with the movement of the player
    private void AimRotation()
    {
        if (isWalking) 
        {
            Vector3 vector3 = Vector3.left * movement.x + Vector3.down * movement.y;
            Aim.rotation = Quaternion.LookRotation(Vector3.forward, vector3);
        }
        
    }

    //get the X and Y float direction for the animation
    private void MovementAnimation()
    { 
        if (movement.x != 0 || movement.y != 0)
        {
            //set the float for X and Y in the animatior from the movement variable
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            //change the animation from idle to the walking animation
            animator.SetBool("IsWalking", true);
        }
        else
        {   // if player if not moving the have idle animation
            animator.SetBool("IsWalking", false);
        }     
    }
}
