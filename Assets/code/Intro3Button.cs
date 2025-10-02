using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro3Button : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "intro 3";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
