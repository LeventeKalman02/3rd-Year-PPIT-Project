using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private List<string> sceneHistory = new List<string>(); //running history of scenes
    //The last string in the list is always the current scene running

    // Start is called before the first frame update
    void Start()
    {
        //keeps the gameObject throughout all of the scenes and doesnt delete it
        DontDestroyOnLoad(this.gameObject);
        sceneHistory.Add(SceneManager.GetActiveScene().name);
    }

    //Add the new scene to the sceneHistory list then load the scene
    public void LoadScene(string newScene)
    {
        sceneHistory.Add(newScene);
        SceneManager.LoadScene(newScene);
    }

    //Remove the current scene from the history and then load the new last scene in the history
    //Return false if we have not moved between scenes enough to have stored a previous scene in the history
    public bool PreviousScene()
    {
        bool returnValue = false;
        if (sceneHistory.Count >= 2)
        {
            returnValue = true;
            sceneHistory.RemoveAt(sceneHistory.Count - 1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count - 1]);
        }

        sceneHistory.Add(SceneManager.GetActiveScene().name);

        return returnValue;
    }

    //Quit the application if user presses the button
    public void ExitGame()
    {
        Application.Quit();
    }

    //calls the PreviousScene Function
    //can be used on any "Back" button that is placed into UI
    public void BackButton()
    {
        PreviousScene();
    }

    //transition the scene to the HomeScene when the start game button is pressed
    //public void LaunchGame()
    //{
    //    LoadScene("MainBaseScene");
    //}

    //Take the user to the Controls Scene
    //public void ControlsScene()
    //{
    //    LoadScene("ControlsScene");
    //}

   

}
