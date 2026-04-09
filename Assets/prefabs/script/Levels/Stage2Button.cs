using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Button : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "stage 2";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}


