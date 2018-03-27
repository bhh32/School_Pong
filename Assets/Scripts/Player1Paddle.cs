using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour 
{
	[SerializeField] float speed;

	void Update()
	{
		bool moveUp = Input.GetKey (KeyCode.W);
		bool moveDown = Input.GetKey (KeyCode.S);
		if (moveUp)
			transform.Translate (0f, speed * Time.deltaTime, 0f);
		else if (moveDown)
			transform.Translate (0f, -speed * Time.deltaTime, 0f);
	}
}
