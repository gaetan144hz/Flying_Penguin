using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SC_Figure : MonoBehaviour
{
    private SC_Score sc;
    //public UnityEvent onRotationComplete;
    public bool deg90;
    public bool deg180;
    public bool deg270;
    public bool deg360;
    private Rigidbody2D rb;
    [SerializeField] private float rest;

    void Start()
    {
        OnStartDeg();
        
        rb = GetComponent<Rigidbody2D>();
        sc = GetComponent<SC_Score>();
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(rb.rotation) >= 90)
        {
            deg90 = true;
            sc.score += 90;
        }

        if (Mathf.Abs(rb.rotation) >= 180)
        {
            deg180 = true;
            sc.score += 180;
        }
        
        if (Mathf.Abs(rb.rotation) >= 270)
        {
            deg270 = true;
            sc.score += 270;
        }
        
        if (Mathf.Abs(rb.rotation) >= 350)
        {
            sc.score += 360;

            var lastRota = Mathf.Abs(rb.rotation);
            rest = lastRota %= 360;
            rb.rotation = rest;
            
            deg360 = true;
            
            deg90 = false;
            deg180 = false;
            deg270 = false;
            deg360 = false;
        }
    }

    void Update()
    {
        if (!deg90)
            return;
        Debug.Log("90");
        
        if (!deg180)
            return;
        Debug.Log("180");
        
        if (!deg270)
            return;
        Debug.Log("270");
        
        if (!deg360)
            return;
        Debug.Log("360");
    }

    public void OnStartDeg()
    {
        deg90 = false;
        deg180 = false;
        deg270 = false;
        deg360 = false;
    }
}
