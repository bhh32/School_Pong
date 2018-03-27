using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            playerScore = value;
            playerScoreText.text = string.Format("Player: {0}", playerScore);
            playerScoreShadow.text = playerScoreText.text;
        }
        get { return playerScore; }
    }

    private int npcScore;

    public int NpcScore
    {
        set
        {
            npcScore = value;
            npcScoreText.text = string.Format("NPC: {0}", npcScore);
            npcScoreShadow.text = npcScoreText.text;
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
        winLoseText.text = string.Format("You Lose!");
        Time.timeScale = 0f;
    }

    public void Win()
    {
        winLossCanvas.SetActive(true);
        winLoseText.text = string.Format("You Win!");
        Time.timeScale = 0f;
    }
}
