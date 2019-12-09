﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() //Loads the scene with the selected map
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex; //Finds current scene index
        MapState mapChoice = GlobalControl.Instance.Map; //Gets ID for selected map
        int mc = mapChoice.GetStateID();
        SceneManager.LoadScene(currentsceneindex + mc + 1); //Loads scene
    }
}
