using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{    
    [SerializeField] private float lerpTime;
    [SerializeField] private float time;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.CompareTag("Penguin"))
            return;
        Debug.Log("t mort");
    }
}
