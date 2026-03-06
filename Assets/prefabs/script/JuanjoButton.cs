using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuanjoButton : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Juanjo_sound";

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
