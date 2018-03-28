using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour 
{
	[SerializeField] float speed; // Players Speed

	void Update()
	{
		bool moveUp = Input.GetKey (KeyCode.W); // Key to move up
		bool moveDown = Input.GetKey (KeyCode.S); // Key to move down
		
        // If moveUp is true...
        if (moveUp)
            // Move the paddle up
			transform.Translate (0f, speed * Time.deltaTime, 0f);
        // If moveDown is true...
		else if (moveDown)
            // Move the paddle down
			transform.Translate (0f, -speed * Time.deltaTime, 0f);
	}
}
