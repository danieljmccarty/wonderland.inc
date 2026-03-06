using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewsButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "New Arrow";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
