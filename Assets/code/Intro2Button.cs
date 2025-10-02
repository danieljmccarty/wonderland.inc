using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro2Button : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "intro 2";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
