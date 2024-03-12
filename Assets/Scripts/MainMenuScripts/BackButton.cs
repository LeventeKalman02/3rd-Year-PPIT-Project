using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    private SceneManagerScript setPreviousScene;

    //gets the object with the tag "scenemanager" and get the script component
    //calls the BackButton function from the scene manager script
    public void Back()
    {
        setPreviousScene = GameObject.FindWithTag("SceneManager").GetComponent<SceneManagerScript>();
        setPreviousScene.BackButton();
    }

}
