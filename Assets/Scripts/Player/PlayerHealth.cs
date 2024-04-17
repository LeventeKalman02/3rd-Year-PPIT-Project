using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool isDead = false;

    [SerializeField] private HealthBar healthBar;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private PlayerMovement playerMove;
    [SerializeField] private Attack playerAttack;    

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        //set your current health to the max
        currentHealth = maxHealth;
        //set the slider to max health
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //testing damage and healthbar
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(20);
        //}
        ProcessDeath();
    }

    //take health when player takes damage
    public void TakeDamage(int damage)
    {        
        currentHealth -= damage;//take damage
        healthBar.SetHealth(currentHealth);//apply damage to healthbar
    }

    //check if health has reached 0
    public void ProcessDeath()
    {
        //if health is 0 then disable the player and enable the death screen
        if (currentHealth <= 0)
        {
            isDead = true;//set isDead to true
            deathScreen.SetActive(true);
            //set everything the player can do to false
            playerSprite.enabled = false;
            playerMove.enabled = false;
            playerAttack.enabled = false;
        }
    }
}
