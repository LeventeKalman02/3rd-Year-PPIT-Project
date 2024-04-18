using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private GameObject melee;
    private PlayerHealth player;
    //private bool isAttacking = false;

    //attack timer
    //[SerializeField] private float atkDuration = 0.3f;
    //[SerializeField] private float atkTimer = 0f;
    [SerializeField] private int atkdamage = 10;
    [SerializeField] private float atkrange = 10;
    [SerializeField] private float atkDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        //CheckMeleeTimer();
    }

    //melee attack
    //public void OnAttack()
    //{
    //    if (!isAttacking)
    //    {
    //        melee.SetActive(true);
    //        isAttacking = true;

    //        //melee attack animation here
    //    }
    //}

    ////checking cooldown for attacking
    //private void CheckMeleeTimer()
    //{
    //    if (isAttacking)
    //    {
    //        atkTimer += Time.deltaTime;
    //        if (atkTimer >= atkDuration)
    //        {
    //            atkTimer = 0;
    //            isAttacking = false;
    //            melee.SetActive(false);
    //        }
    //    }
    //}

    //detect the collision with the player to start the attacking
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //player = collision.gameObject.GetComponent<PlayerHealth>();
        //Debug.Log("Collision");

        //if (player != null) 
        //{
        //    OnAttack();
        //}
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {
            Debug.Log("Player detected " + atkDelay);
            melee.SetActive(true);
            //Prevent damage stacking
            StopCoroutine(DelayTimer(obj));
            //Attack player timer
            StartCoroutine(DelayTimer(obj));
        }
    }

    ////delay for attacking
    IEnumerator DelayTimer(GameObject player)
    {
        yield return new WaitForSeconds(atkDelay);
        if(Vector2.Distance(transform.position, player.transform.position) < atkrange)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(atkdamage);
        }
        melee.SetActive(false);
    }
}
