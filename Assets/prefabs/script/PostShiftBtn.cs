using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PostShiftBtn : MonoBehaviour
{
    [SerializeField] private string postGameLevel = "post shift";

    public void newGameButton()
    {
        SceneManager.LoadScene(postGameLevel);
    }
}
