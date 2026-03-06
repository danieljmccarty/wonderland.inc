using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArcadeButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "arcade";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}

