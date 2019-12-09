using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOp : MonoBehaviour
{

    [SerializeField] Text textComponent;
    // Start is called before the first frame update
    void Start()
    {
        if (GlobalControl.Instance.Win == 1) //Changes message based on who won the last ame
            textComponent.text = ("Player 1 Wins!");
        else if (GlobalControl.Instance.Win == 2)
            textComponent.text = ("Player 2 Wins!");
    }

    // Update is called once per frame
    public void ReturnToChar()
    {
        SceneManager.LoadScene(1); //Loads character select screen
    }

    public void ReturnToMatch()
    {
        int mc = GlobalControl.Instance.Map.GetStateID(); //Gets scene number for the last stage selected

        SceneManager.LoadScene(mc+2); //Reloads previously used scene
    }

}
