using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "take a tour";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
