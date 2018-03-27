using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWall : MonoBehaviour 
{
    ScoringManager scoreMan;
    [SerializeField] Ball ball;

    void Awake()
    {
        scoreMan = GameObject.FindGameObjectWithTag("ScoringManager").GetComponent<ScoringManager>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ball") && gameObject.name == "RightWall")
        {
            scoreMan.PlayerScore++;

            if (scoreMan.PlayerScore >= 10)
            {
                scoreMan.PlayerScore = 10;
                scoreMan.Win();
            }
            else
            {
                ball.ResetBall();
            }
        }
        else if (other.collider.CompareTag("Ball") && gameObject.name == "LeftWall")
        {
            scoreMan.NpcScore++;

            if (scoreMan.NpcScore >= 10)
            {
                scoreMan.NpcScore = 10;
                scoreMan.Lose();
            }
            else
            {
                ball.ResetBall();
            }
        }
    }
}
