using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "act1";

    public void NewGameButton() 
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
