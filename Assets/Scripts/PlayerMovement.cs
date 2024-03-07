using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 600f;
    [SerializeField] private Vector2 movement;

    private Animator animator;

    private void Awake()
    {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
        //get animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        MovementAnimation();
    }

    private void Movement()
    {
        movement = new Vector2();

        //left and right
        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector2.left * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += Vector2.right * moveSpeed;
        }

        //up and down
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector2.up * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement += Vector2.down * moveSpeed;
        }

        rb.velocity = movement * Time.fixedDeltaTime;

    }
    //get the X and Y float direction for the animation
    private void MovementAnimation()
    { 
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            //change the animation from idle to the walking animation
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }     
    }
}
