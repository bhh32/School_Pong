using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPaddle : MonoBehaviour 
{
	GameObject ball;
	[SerializeField] float speed;

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

	void CalculateBallPos(GameObject b)
	{
		float dist = Vector2.Distance (b.transform.position, transform.position);

		if (dist < 11f) 
		{
			float tempPos = b.transform.position.y / speed;
			transform.position = new Vector3(transform.position.x, tempPos, transform.position.z);
		}
	}
}
