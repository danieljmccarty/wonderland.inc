using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Button : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "stage 1";

    public void NewGameButton() 
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
