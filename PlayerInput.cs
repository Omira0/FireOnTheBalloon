using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Animator anime;
    public Rigidbody2D myRigiBody;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] float movement;
    [SerializeField] const int SPEED = 4;
    


    // Start is called before the first frame update
    void Start()
    {

 
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        bool isFlying = Input.GetKey(KeyCode.Space);

        // Set isFlying parameter in the animator
        anime.SetBool("isFlying", isFlying);

        if (isFlying)
        {
          
            // Apply vertical velocity for the jump
            myRigiBody.velocity = Vector2.up * 4;
            
        }
        
    }
    private void FixedUpdate()
    {
        myRigiBody.velocity = new Vector2(SPEED * movement, myRigiBody.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();

    }
    private void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
    private void OnBecameInvisible()
    {
        // Destroy the game object when it becomes invisible
        Destroy(gameObject);
    }
}
