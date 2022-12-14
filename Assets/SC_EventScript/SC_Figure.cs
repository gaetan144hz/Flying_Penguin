using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SC_Figure : MonoBehaviour
{
    //public UnityEvent onRotationComplete;
    private Rigidbody2D rb;

    private List<int> passAngles;
    private int lastAngleIndex = 1;

    void Start()
    {
        passAngles = new List<int>(5);
        passAngles[0] = 0;

        rb = GetComponent<Rigidbody2D>();
        //sc = GetComponent<SC_Score>();
    }

    private void FixedUpdate()
    {
        if (rb.rotation < 0)
        {
            rb.rotation = 360 + rb.rotation;
        }

        rb.rotation %= 360;
            
        switch (rb.rotation)
        {
            case >= 80 and <= 100:
                UpdateQueue(90);
                break;
            case >= 170 and <= 190:
                UpdateQueue(180);
                break;
            case >= 260 and <= 280:
                UpdateQueue(270);
                break;
            case >= 350:
                UpdateQueue(360);
                break;
        }
    }

    void UpdateQueue(int checkpoint)
    {
        // si different alors on l'ajoute à la queue
        if (checkpoint == passAngles[lastAngleIndex - 1]) // si l'angle passez est deja le derniere angle enregistré
            return;
        
        // a l'index lastCheckpoint index 
        passAngles[lastAngleIndex] = checkpoint;
        
        lastAngleIndex++;
        
        if (lastAngleIndex == 5)
        {
            foreach (var listDangle in passAngles)
            {
                
            }

        }
    }

    void Update()
    {

    }
}
