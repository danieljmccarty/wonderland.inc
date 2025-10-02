using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TycoonButton : MonoBehaviour
{
    [SerializeField] private string nextGameLevel = "tycoon";

    public void newGameButton()
    {
        SceneManager.LoadScene(nextGameLevel);
    }
}
