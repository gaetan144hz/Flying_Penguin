using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Breaker : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Penguin"))
        {
            Destroy(col.gameObject);
            Debug.Log("t mort nullos enfant de 7 ans");
        }
    }
    
}
