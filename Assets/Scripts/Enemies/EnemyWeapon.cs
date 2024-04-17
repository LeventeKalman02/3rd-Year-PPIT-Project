using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    [SerializeField] private int atkdamage = 10;
    [SerializeField] private float atkDelay = 1f;
    private PlayerHealth player;

    // if attack radius collides with player object which contains player health
    //player takes damage 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<PlayerHealth>();        

        if (player != null)
        {
            StartCoroutine(DelayTimer());
            Debug.Log("Delay over");

            player.TakeDamage(atkdamage);
            Debug.Log("player damage" + atkdamage);
            Debug.Log("current player health" + player.currentHealth);
        }
    }

    //delay for attacking
    IEnumerator DelayTimer()
    {
        yield return new WaitForSeconds(atkDelay);
    }
}
