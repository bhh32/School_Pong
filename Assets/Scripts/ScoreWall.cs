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
        // Get the score manager
        scoreMan = GameObject.FindGameObjectWithTag("ScoringManager").GetComponent<ScoringManager>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the ball hits the right wall...
        if (other.collider.CompareTag("Ball") && gameObject.name == "RightWall")
        {
            // Give the player a point
            scoreMan.PlayerScore++;

            // Play the score audio
            ballAudio.PlayOneShot(scoreClip);

            // If the score is at the winning score...
            if (scoreMan.PlayerScore >= 7)
            {
                // Ensure the score stays at the winning score...
                scoreMan.PlayerScore = 7;
                // ... and call the win method
                scoreMan.Win();
            }
            else
            {
                // Otherwise, reset the ball
                ball.ResetBall();
            }
        }
        // If the ball hits the left wall...
        else if (other.collider.CompareTag("Ball") && gameObject.name == "LeftWall")
        {
            // Give the npc or player 2 the point
            scoreMan.NpcScore++;

            // Play the score audio
            ballAudio.PlayOneShot(scoreClip);
            // If the score is the winning score...
            if (scoreMan.NpcScore >= 7)
            {
                // Ensure the score stays at the winning score...
                scoreMan.NpcScore = 7;
                // ... and call the lose method (to say that the npc or player 2 won)
                scoreMan.Lose();
            }
            else
            {
                // Otherwise, reset the ball
                ball.ResetBall();
            }
        }
    }
}
