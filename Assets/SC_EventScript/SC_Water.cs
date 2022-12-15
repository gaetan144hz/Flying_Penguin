using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class SC_Water : MonoBehaviour
{
    [SerializeField] float multiplierUp;
    [SerializeField] float multiplierRight;
    
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.gameObject.CompareTag("Penguin"))
            return;
        var rb = col.gameObject.GetComponent<Rigidbody2D>();
        rb.rotation = 0f;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        Vector3 forceUp = col.transform.up * multiplierUp;
        Vector3 forceRight = col.transform.right * multiplierRight;
        col.GetComponent<Rigidbody2D>().AddForce(forceUp);
        col.GetComponent<Rigidbody2D>().AddForce(forceRight);
    }
}
