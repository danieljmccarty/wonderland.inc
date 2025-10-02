using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetMeHelpButton : MonoBehaviour
{
    [SerializeField] private string helpGameLevel = "let me help";

    public void NewGameButton()
    {
        SceneManager.LoadScene(helpGameLevel);
    }
}