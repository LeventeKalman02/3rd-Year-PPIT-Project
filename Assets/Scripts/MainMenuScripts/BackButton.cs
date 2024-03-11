using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    private SceneManagerScript setPreviousScene;

    public void Back()
    {
        setPreviousScene = GameObject.FindWithTag("SceneManager").GetComponent<SceneManagerScript>();
        setPreviousScene.BackButton();
    }

}
