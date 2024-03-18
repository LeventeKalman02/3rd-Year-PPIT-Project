using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTeleport : MonoBehaviour
{
    //when player enters the portal, transfer to the fighting arena
    private void OnTriggerEnter2D(Collider2D other)
    {
        //check for the Player tag
        if (other.gameObject.tag == "Player")
        {
            //call the singleton in the scene transition script to load the scene
            SceneTransitionScript.instance.StartAnimation("ArenaScene");
        }
    }
}
