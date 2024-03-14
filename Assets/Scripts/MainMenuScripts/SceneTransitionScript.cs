using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    //getting the animator and setting transition time default. Can be changed in editor
    public Animator transition;
    public float transitionTime = 1f;

    private SceneManagerScript sceneLoad;

    private void Start()
    {
        //make sure object persists so that the animation can be used throughout the game
        DontDestroyOnLoad(this.gameObject);
    }

    //call the Coroutine
    public void StartAnimation()
    {
        StartCoroutine(TransitionScene());
    }

    //Coroutine for animation and delay
    IEnumerator TransitionScene()
    {
        //play animation
        transition.SetTrigger("Start");

        //wait for the animation to play
        yield return new WaitForSeconds(transitionTime);

        sceneLoad.LoadScene("MainBaseScene");
    }
}
