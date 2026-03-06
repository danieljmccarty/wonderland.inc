using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonderlandCom : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "wonderland.com";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
