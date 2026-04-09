using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage7Button : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "stage 7";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}
