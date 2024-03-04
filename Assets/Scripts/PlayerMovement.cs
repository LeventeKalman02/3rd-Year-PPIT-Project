using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 600f;
    [SerializeField] private Vector2 movement;

    private void Awake()
    {
        //get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
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
}
