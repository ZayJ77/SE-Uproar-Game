using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")] //Creates option to create State object
public class State : ScriptableObject
{
    [SerializeField] Sprite charsprite; //Stores icon for character in the select screen
    [SerializeField] State[] nextStates; //Stores other states to transition to
    [SerializeField] int IDNum; //ID number to track which state is currently active

    public Sprite GetStateSprite()
    {
        return charsprite;
    }

    public int GetIDNum()
    {
        return IDNum;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
