using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Rigidbody2D rb;
    //default values, can be changed in editor
    public float moveSpeed = 5f;
    public float health, maxHealth = 3f;

    private Transform player;
    private Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        //find the player object with code rather than using the editor
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //every time an enemy spawns health is set to max
        health = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        //find the direction of the player 
        if (player)
        {
            Vector3 direction = (player.position - transform.position).normalized;//use normalized as we dont use rotation
            moveDirection= direction;
        }
    }

    private void FixedUpdate()
    {
        //set the direction and move the enemy towards the player
        if (player)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    //take health if enemy takes damage 
    public void TakeDamage(float damage)
    {
        health = health - damage;
        Debug.Log("Damage = " + damage);
        Debug.Log("Health = " + health);
        //if health is less or equal to 0 then destroy the enemy object instance
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
