using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement3 : MonoBehaviour
{
    private float moveSpeed = 15f; //Balloon speed *Notice it is faster than level 2 with extra speed = 5f.
    private bool moveRight = true; //To know which direction we are going to.


    // Update is called once per frame
    void Update()
    {

        MoveBalloon(); //calling the movement method.
        CheckScreenEdge(); //calling the check screen method.

    }

    void MoveBalloon()
    {
        //Making a code for the Balloon movement.
        Vector2 movement = moveRight ? Vector2.right : Vector2.left;

        transform.Translate(movement * moveSpeed * Time.deltaTime);


    }

    //Making a code for the Balloon to adjust if to goes right or left
    void CheckScreenEdge()
    {
        float screenWidth = Camera.main.orthographicSize * Screen.width / Screen.height;

        if (transform.position.x >= screenWidth)
        {
            moveRight = false;
        }
        else if (transform.position.x <= -screenWidth)
        {
            moveRight = true;
        }
    }

    private void OnBecameInvisible() //A method to make the balloon vanished 

    {
        // Destroy the game object when it becomes invisible
        Destroy(gameObject);
    }
}
