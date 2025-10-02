using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopoysPaperTheater : MonoBehaviour
{
    [SerializeField] private string popoyGameLevel = "popoy's paper theater";

    public void NewGameButton()
    {
        SceneManager.LoadScene(popoyGameLevel);
    }
}
