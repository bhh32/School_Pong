using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public void SinglePlayerGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void TwoPlayerGame()
    {
        SceneManager.LoadScene("TwoPlayerGame");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        #if UNITY_STANDALONE
        Application.Quit();
        #endif
    }
}
