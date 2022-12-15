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
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Water"))
        {
            Instantiate(fx, transform.position, Quaternion.identity);
        }
    }
}
