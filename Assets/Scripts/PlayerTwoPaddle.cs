using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoPaddle : MonoBehaviour 
{
    [SerializeField] float speed;

    void Update()
    {
        bool moveUp = Input.GetKey (KeyCode.UpArrow);
        bool moveDown = Input.GetKey (KeyCode.DownArrow);
        if (moveUp)
            transform.Translate (0f, speed * Time.deltaTime, 0f);
        else if (moveDown)
            transform.Translate (0f, -speed * Time.deltaTime, 0f);
    }
}
