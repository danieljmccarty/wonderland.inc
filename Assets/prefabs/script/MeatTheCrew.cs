using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeatTheCrew : MonoBehaviour
{

    [SerializeField] private string newGameLevel = "meet the crew";
    public void NewGameButton() 
    {
        SceneManager.LoadScene(newGameLevel);
    }
}