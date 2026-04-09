using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TourDayButton : MonoBehaviour
{


    [SerializeField] private string newGameLevel = "tour day";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

}

    