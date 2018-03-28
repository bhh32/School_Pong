using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringManager : MonoBehaviour 
{
    [Header("HUD Variables")]
    [SerializeField] Text playerScoreText;
    [SerializeField] Text playerScoreShadow;
    [SerializeField] Text npcScoreText;
    [SerializeField] Text npcScoreShadow;
    [SerializeField] Text winLoseText;
    [SerializeField] GameObject winLossCanvas;


    private int playerScore;

    // Property to set and get the player/player 1 score and the associated UI
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

    // Property to set the npc/player 2 score and it's associated UI
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

    // Called When NPC/Player Two Wins
    public void Lose()
    {
        winLossCanvas.SetActive(true);

        // If in the single player game...
        if (SceneManager.GetActiveScene().name == "Game")
            // ... Set The text to "You Lose!"
            winLoseText.text = string.Format("You Lose!");
        else
            // ... Otherwise, set it to "Player 2 Wins!"
            winLoseText.text = string.Format("Player 2 Wins!");

        // Pause the game
        Time.timeScale = 0f;
    }

    // Called when Player/Player 1 Wins
    public void Win()
    {
        winLossCanvas.SetActive(true);

        // If in the single player game...
        if (SceneManager.GetActiveScene().name == "Game")
            // ... Set the text to "You Win!"
            winLoseText.text = string.Format("You Win!");
        else
            // ... otherwise, set the text to "Player 1 Wins!"
            winLoseText.text = string.Format("Player 1 Wins!");

        // Pause the game
        Time.timeScale = 0f;
    }
}
