using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnOffTut : MonoBehaviour
{
    [SerializeField] Canvas canvas; //Canvas object with the tutorial display
    [SerializeField] Image Icon1; //Player 1 icon
    [SerializeField] Image Icon2; //Player 2 icon

    private void Start()
    {
        //Puts the correct character icons beside the life bars, based on character select screen
        Icon1.GetComponent<Image>().sprite = GlobalControl.Instance.Char1.GetStateSprite();
        Icon2.GetComponent<Image>().sprite = GlobalControl.Instance.Char2.GetStateSprite();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Turns off tutorial display
            canvas.gameObject.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Escape)) //Option to quit back to character select
            SceneManager.LoadScene(1);
    }
}
