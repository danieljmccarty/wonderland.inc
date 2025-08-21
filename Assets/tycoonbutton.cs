using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tycoonbutton : MonoBehaviour
{
    [SerializeField] private string nextGameLevel = "tycoon";

    public void NewGameButton()
    {
        SceneManager.LoadScene(nextGameLevel);
    }
}
