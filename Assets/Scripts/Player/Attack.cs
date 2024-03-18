using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //melee
    public GameObject Melee;
    private bool isAttacking = false;
    [SerializeField] private float atkDuration = 0.3f;
    [SerializeField] private float atkTimer = 0f;

    //ranged
    public Transform Aim;
    public GameObject bullet;
    [SerializeField] private float fireForce = 10f;
    [SerializeField] private float shootCooldown = 0.25f;
    [SerializeField] private float shootTimer = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //checks the attack delay timer and get the left mouse button click to attack
        CheckMeleeTimer();
        shootTimer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            OnAttack();
        }
        //shoot with right click
        if (Input.GetMouseButtonDown(1))
        {
            OnShoot();
        }
    }

    //meleeing
    private void OnAttack()
    {
        if(!isAttacking)
        {
            Melee.SetActive(true);
            isAttacking = true;

            //melee attack animation here
        }
    }

    //shooting
    private void OnShoot()
    {
        if (shootTimer > shootCooldown)
        {
            shootTimer = 0;
            //instantiate the bullet game object
            GameObject intBullet = Instantiate(bullet, Aim.position, Quaternion.identity);
            intBullet.transform.eulerAngles = Aim.rotation.eulerAngles + new Vector3(0, 0, 90);
            //add the default force value to the bullet's RigidBody
            intBullet.GetComponent<Rigidbody2D>().AddForce(-Aim.up * fireForce, ForceMode2D.Impulse);
            //destroy instatiated bullet after 2 seconds
            Destroy(intBullet, 2f);
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
