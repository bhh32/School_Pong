using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoPaddle : MonoBehaviour 
{
    [SerializeField] float speed; // Speed of the paddle

    void Update()
    {
        bool moveUp = Input.GetKey (KeyCode.UpArrow); // Move the paddle up
        bool moveDown = Input.GetKey (KeyCode.DownArrow); // Move the paddle down

        // If moveUp is true...
        if (moveUp)
            // ... Move the paddle up
            transform.Translate (0f, speed * Time.deltaTime, 0f);
        // If moveDown is true...
        else if (moveDown)
            // ... Move the paddle down
            transform.Translate (0f, -speed * Time.deltaTime, 0f);
    }
}
