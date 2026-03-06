using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "comics";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
