using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "menu";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
