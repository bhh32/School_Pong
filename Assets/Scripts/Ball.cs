using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{    
    Rigidbody2D rb; // The ball rigidbody
    float xSpeed; // The speed of the ball on the x-axis
    float ySpeed; // The speed of the ball on the y-axis
    int rando; // The random variable that chooses whether the x and/or y are neg or pos
    [SerializeField] float startSpeed; // The base speed of the ball on all axis
    AudioSource bounceSound; // The sound of the ball when it bounces

    Vector3 v; // The variable to manipulate the rigidbody velocity

	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
        bounceSound = GetComponent<AudioSource>();

        // Set the ball in motion initially
        ResetBall();         
	}

	void Update()
	{
        // Update the ball's velocity
        rb.velocity = v * Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the ball hits the top or bottom wall reverse the direction of the ball
        if (other.collider.CompareTag("TopWall") || other.collider.CompareTag("BottomWall"))
        {
            bounceSound.PlayOneShot(bounceSound.clip);
            v.y *= -1f;
        }
        // If the ball hits a paddle reverse the direction of the ball
        else if (other.collider.CompareTag("Paddle"))
        {
            bounceSound.PlayOneShot(bounceSound.clip);
            v.x *= -1f;
        }
    }

    // Used to reset the ball and set its initial velocity
    public void ResetBall()
    {
        // Place the ball in the middle of the "court"
        transform.position = new Vector3(0f, 0f, 0f);

        // Set rando between 0 and 1
        rando = Random.Range(0, 2);

        // Check rando to set the direction of the x-axis
        switch (rando)
        {
            case 0:
                xSpeed = startSpeed * -1f;
                break;
            case 1:
                xSpeed = startSpeed;
                break;
        }

        // Reset rando between 0 and 1
        rando = Random.Range(0, 2);

        // Check rando to set the direction of the y-axis
        switch (rando)
        {
            case 0:
                ySpeed = startSpeed * -1f;
                break;
            case 1:
                ySpeed = startSpeed;
                break;
        }

        // Set the velocity variable to the speeds on all axis
        v = new Vector3(xSpeed, ySpeed, 0f);   
    }
}
