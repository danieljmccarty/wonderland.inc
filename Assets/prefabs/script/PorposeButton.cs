using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorposeButton : MonoBehaviour
{
    [SerializeField] private string popGameLevel = "perpose";

    public void NewGameButton()
    {
        SceneManager.LoadScene(popGameLevel);
    }
}
