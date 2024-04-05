using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //make sure gameobject is off at start
        gameObject.SetActive(false);
    }

    //button to return to base scene
    public void ReturnToBase()
    {
        //calls OnDeath from the PlayerHealth script
        SceneManager.LoadScene("MainBaseScene");

    }
}
