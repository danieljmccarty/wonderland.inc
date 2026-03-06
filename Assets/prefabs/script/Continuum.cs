using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continuum : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "continuum";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
