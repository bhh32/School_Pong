using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{
	Rigidbody2D rb;
    float xSpeed;
    float ySpeed;
    int rando;
    [SerializeField] float startSpeed;

    Vector3 v;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
        ResetBall();         
	}

	void Update()
	{
        rb.velocity = v * Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("TopWall") || other.collider.CompareTag("BottomWall"))
            v.y *= -1f;
        else if (other.collider.CompareTag("Paddle"))
            v.x *= -1f;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(0f, 0f, 0f);

        rando = Random.Range(0, 2);

        switch (rando)
        {
            case 0:
                xSpeed = startSpeed * -1f;
                break;
            case 1:
                xSpeed = startSpeed;
                break;
        }

        rando = Random.Range(0, 2);

        switch (rando)
        {
            case 0:
                ySpeed = startSpeed * -1f;
                break;
            case 1:
                ySpeed = startSpeed;
                break;
        }

        v = new Vector3(xSpeed, ySpeed, 0f);   
    }
}
