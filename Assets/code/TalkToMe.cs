using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TalkToMe : MonoBehaviour
{
    [SerializeField] private string talkGameLevel = "talk to me";

    public void NewGameButton()
    {
        SceneManager.LoadScene(talkGameLevel);
    }
}

