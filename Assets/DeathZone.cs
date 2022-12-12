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
        if (col.gameObject.CompareTag("Penguin"))
        {
            OnLerp(col.gameObject);
            Debug.Log("t mort");
        }
    }
    
    public void OnLerp(GameObject lerpObject)
    {
        lerpObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,90), time);
        time += Time.deltaTime / lerpTime;
    }
}
