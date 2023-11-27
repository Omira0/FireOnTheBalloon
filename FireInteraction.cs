using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInteraction : MonoBehaviour
{
    [SerializeField] const int FireSpeed = 2;
    private Rigidbody2D riBody;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        // Assign the Rigidbody2D component to riBody
        riBody = GetComponent<Rigidbody2D>();

        // Set the velocity
        riBody.velocity = transform.right * FireSpeed;

        Debug.Log("Object is moving to the right.");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

