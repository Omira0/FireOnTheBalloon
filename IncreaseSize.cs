using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseDestroy : MonoBehaviour
{
    public float growthRate = 0.2f; // Rate at which the GameObject grows per second
    private float elapsedTime = 0f; // Time elapsed since the script started

    void Update()
    {
        // Increase the elapsed time
        elapsedTime += Time.deltaTime;

        
            // increase the balloon size every 6 seconds
            if (elapsedTime % 6f < Time.deltaTime)
            {
                // Increase the balloon size
                transform.localScale += new Vector3(growthRate, growthRate, 0f);
            }
        
    }
}

