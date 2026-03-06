using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TablesButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "tables";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}

