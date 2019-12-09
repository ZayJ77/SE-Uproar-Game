using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnP1 : MonoBehaviour
{

    [SerializeField] GameObject[] playerones; //Stores all character prefabs
    [SerializeField]
    private Transform spawn; //Stores spawning position

    // Start is called before the first frame update
    void Start()
    {
        int charChoice = GlobalControl.Instance.Char1.GetIDNum(); //Gets the ID number for the caracter selected
        Instantiate(playerones[charChoice-1], spawn.position, spawn.rotation); //Spawns character prefab based on ID num
    }

}
