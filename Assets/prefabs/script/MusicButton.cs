using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Music";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
