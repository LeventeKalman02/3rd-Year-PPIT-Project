using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Melee;
    private bool isAttacking = false;
    [SerializeField] private float atkDuration = 0.3f;
    [SerializeField] private float atkTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        //checks the attack delay timer and get the left mouse button click to attack
        CheckMeleeTimer();
        if (Input.GetMouseButtonDown(0))
        {
            OnAttack();
        }        
    }

    //attacking 
    private void OnAttack()
    {
        if(!isAttacking)
        {
            Melee.SetActive(true);
            isAttacking = true;

            //melee attack animation here
        }
    }

    //checking cooldown for attacking
    private void CheckMeleeTimer()
    {
        if(isAttacking) 
        { 
            atkTimer += Time.deltaTime;
            if(atkTimer >= atkDuration)
            {
                atkTimer = 0;
                isAttacking= false;
                Melee.SetActive(false);
            }
        }
    }
}
