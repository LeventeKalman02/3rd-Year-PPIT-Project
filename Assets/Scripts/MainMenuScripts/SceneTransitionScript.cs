using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    //singleton
    public static SceneTransitionScript instance;

    //getting the animator and setting transition time default. Can be changed in editor
    public Animator transition;
    public float transitionTime = 1f;

    private void Awake()
    {
        //make sure object persists so that the animation can be used throughout the game
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    //call the Coroutine
    public void StartAnimation(string scene)
    {
        StartCoroutine(TransitionScene(scene));
    }

    //Coroutine for animation and delay
    IEnumerator TransitionScene(string scene)
    {
        //play fade out animation
        transition.SetTrigger("End");
        
        //wait for the animation to play
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);

        //play fade in animation
        transition.SetTrigger("Start");
    }
}
