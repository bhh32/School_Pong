using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringManager : MonoBehaviour 
{
    [SerializeField] Text playerScoreText;
    [SerializeField] Text playerScoreShadow;
    [SerializeField] Text npcScoreText;
    [SerializeField] Text npcScoreShadow;
    [SerializeField] Text winLoseText;

    [SerializeField] GameObject winLossCanvas;

    private int playerScore;

    public int PlayerScore
    {
        set
        { 
            if (SceneManager.GetActiveScene().name == "Game")
            {
                playerScore = value;
                playerScoreText.text = string.Format("Player: {0}", playerScore);
                playerScoreShadow.text = playerScoreText.text;
            }
            else
            {
                playerScore = value;
                playerScoreText.text = string.Format("Player 1: {0}", playerScore);
                playerScoreShadow.text = playerScoreText.text;
            }
        }
        get { return playerScore; }
    }

    private int npcScore;

    public int NpcScore
    {
        set
        {
            if (SceneManager.GetActiveScene().name == "Game")
            {
                npcScore = value;
                npcScoreText.text = string.Format("NPC: {0}", npcScore);
                npcScoreShadow.text = npcScoreText.text;
            }
            else
            {
                npcScore = value;
                npcScoreText.text = string.Format("Player 2: {0}", npcScore);
                npcScoreShadow.text = npcScoreText.text;
            }
        }
        get
        {
            return npcScore;
        }
    }

    void Awake()
    {
        winLossCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

	// Use this for initialization
	void Start () 
    {
        PlayerScore = 0;
        NpcScore = 0;
	}

    public void Lose()
    {
        winLossCanvas.SetActive(true);
        if (SceneManager.GetActiveScene().name == "Game")
            winLoseText.text = string.Format("You Lose!");
        else
            winLoseText.text = string.Format("Player 2 Wins!");
        
        Time.timeScale = 0f;
    }

    public void Win()
    {
        winLossCanvas.SetActive(true);
        if (SceneManager.GetActiveScene().name == "Game")
            winLoseText.text = string.Format("You Win!");
        else
            winLoseText.text = string.Format("Player 1 Wins!");
        
        Time.timeScale = 0f;
    }
}
