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
    //private int lastAngleIndex = 1;
    
    [SerializeField] private float oldrot;
    [SerializeField] private float oldDelta;
    private SC_Score sc;

    void Start()
    {
        passAngles = new List<int>(5);
        passAngles[0] = 0;

        rb = this.GetComponent<Rigidbody2D>();
        sc = GetComponent<SC_Score>();
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(rb.rotation) > -360)
        {
            rb.rotation = 0;
        }
    }
    
    
}

///////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////

/*
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
float delta = rb.rotation - oldrot;
        
if(delta < 0 && oldDelta < 0)
{
    rb.rotation = 360 + rb.rotation;
}
else if(delta >0 && oldDelta >0)
{
    rb.rotation = 360 - rb.rotation;
}
else
{
    // On a changé de sens
}
        
rb.rotation %= 360;
        
if(oldrot != rb.rotation)
{
    if (oldrot < 90 && rb.rotation >= 90)
    {
        sc.score = 90;
    }
    if (oldrot < 180 && rb.rotation >= 180)
    {
        sc.score = 180;
    }
    if (oldrot < 90 && rb.rotation >= 90)
    {
        sc.score = 270;
    }
    if (oldrot < 359.90 && rb.rotation >= 0)
    {
        sc.score = 360;
    }
}
*/

/*
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
           sc.score += 100;
           
           if (passAngles[1] == 90)
           {
               sc.score += 90;
           }
           if (passAngles[1] == 180)
           {
               sc.score += 180;
           }
           if (passAngles[1] == 270)
           {
               sc.score += 270;
           }
           if (passAngles[1] == 360)
           {
               sc.score += 360;
           }
       }
   }
   */
   