using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Shoot when left click is used.
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    //Method for shooting.
    void Shoot()
    {
        Instantiate(firePrefab, firePoint.position, firePoint.rotation);
    }
}
