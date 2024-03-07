using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //transition the scene to the HomeScene when the start game button is pressed
    public void LaunchGame()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
