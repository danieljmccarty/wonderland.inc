using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouGotMail : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "New Mail";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}
