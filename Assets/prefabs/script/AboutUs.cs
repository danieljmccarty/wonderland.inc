using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUs : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "about us";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
