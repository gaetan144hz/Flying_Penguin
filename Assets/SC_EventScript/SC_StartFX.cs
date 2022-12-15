using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_StartFX : MonoBehaviour
{
    public GameObject fx;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Water"))
        {
            Instantiate(fx, transform.position, Quaternion.identity);
        }
    }
}
