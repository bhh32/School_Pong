using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour 
{
	Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		if (rb.velocity == Vector2.zero)
			rb.AddForce (new Vector2(Random.Range (-300f, 300f), Random.Range (-300f, 300f)), ForceMode2D.Force);

		if (rb.velocity.x > -10f && rb.velocity.x < 10f || rb.velocity.y > -10f && rb.velocity.y < 10f) 
		{
			FixVelocity (rb.velocity, rb);
		}
	}

	void Update()
	{
		// Implement If You Want To Play Crazy Pong
//		if (rb.velocity.x > -10f && rb.velocity.x < 10f || rb.velocity.y > -10f && rb.velocity.y < 10f) 
//		{
//			FixVelocity (rb.velocity, rb);
//		}

		if (rb.velocity.x > -2f && rb.velocity.x < 2f || rb.velocity.y > -2f && rb.velocity.y < 2f)
			FixVelocity (rb.velocity, rb);
	}

	void FixVelocity(Vector2 vel, Rigidbody2D rb2D)
	{
		if (vel.x > -10f && vel.x < 10f)
			rb2D.AddForce(new Vector2(Random.Range(-300f, 300f), vel.y));
		else if (vel.y > -10f && vel.x < 10f)
			rb2D.AddForce(new Vector2(vel.x, Random.Range(-300f, 300f)));
	}
}
