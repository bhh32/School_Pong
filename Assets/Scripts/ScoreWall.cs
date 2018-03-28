using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWall : MonoBehaviour 
{
    ScoringManager scoreMan;
    [SerializeField] Ball ball;

    [Header("Audio")]
    [SerializeField] AudioSource ballAudio;
    [SerializeField] AudioClip scoreClip;

    void Awake()
    {
        scoreMan = GameObject.FindGameObjectWithTag("ScoringManager").GetComponent<ScoringManager>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ball") && gameObject.name == "RightWall")
        {
            scoreMan.PlayerScore++;

            ballAudio.PlayOneShot(scoreClip);
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

            ballAudio.PlayOneShot(scoreClip);
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
