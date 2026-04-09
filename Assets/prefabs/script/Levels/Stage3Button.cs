using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3Button : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "stage 3";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}

