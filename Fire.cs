using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fire : MonoBehaviour
{
    
    public float speed = 10f; // Speed of the fire.
    //to be able to recall the rigidBody.
    public Rigidbody2D rb; // Reference to the Rigidbody2D component

    public AudioSource audioShoot;
                          

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = transform.right * speed; 
        // Set the velocity to move the projectile in the right direction 
        // It actually depends on where the bird is looking at.

    }

    //a method to kill the balloon (Enemy) while avoiding any damage to the bird (Player).
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            // If it's not the player 
            Destroy(gameObject);
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                GameControl.control.SetScore(GameControl.control.GetScore() + 250);
                //adds 250 points each time you kill the enemy.
                Debug.Log("Score:" + GameControl.control.GetScore());
            }
        }
    }

    private void OnBecameInvisible()
    {
        // Destroy the game object when it becomes invisible
        Destroy(gameObject);
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            audioShoot.Play();//for the fire shot
        }
    }
}
