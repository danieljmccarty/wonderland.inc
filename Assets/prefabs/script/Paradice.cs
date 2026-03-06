using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paradice : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "paradice";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
