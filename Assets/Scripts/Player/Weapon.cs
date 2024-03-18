using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float damage = 1f;

    //if attack cone collides with an object containing the enemyScript
    //enemy takes damage equal to the damage float
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyScript enemy = collision.gameObject.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
