using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPaddle : MonoBehaviour 
{
	GameObject ball; // The ball
	[SerializeField] float speed; // Paddle speed

	// Use this for initialization
	void Awake () 
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");	
	}
	
	// Update is called once per frame
	void Update () 
	{
		CalculateBallPos(ball);	
	}

    // Calculates where the paddle should move base on ball position and distance from paddle
	void CalculateBallPos(GameObject b)
	{
        // The ball and paddle distance
		float dist = Vector2.Distance (b.transform.position, transform.position);

        // If the distance is 10 units or less...
		if (dist < 11f) 
		{
            // Make a temp position based on the position of the ball's y-axis / by the paddle's speed * 1.25 units
			float tempPos = b.transform.position.y / speed * 1.25f;
            // Set the position of the paddle to the tempPos
			transform.position = new Vector3(transform.position.x, tempPos, transform.position.z);
		}
	}
}
