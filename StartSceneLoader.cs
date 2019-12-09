using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLoader : MonoBehaviour
{
    public void LoadNextScene() //Loads char select screen
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex; //Gets index of current scene
        SceneManager.LoadScene(currentsceneindex + 1); //Loads next scene
    }
}
