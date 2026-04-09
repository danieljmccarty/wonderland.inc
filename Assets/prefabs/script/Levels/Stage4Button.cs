using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage4Button : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "stage 4";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}

