using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "intro";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
