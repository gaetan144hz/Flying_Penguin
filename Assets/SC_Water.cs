using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class SC_Water : MonoBehaviour
{
    [SerializeField] private bool lerpBool;
    [SerializeField] float multiplierUp;
    [SerializeField] float multiplierRight;
    [SerializeField] private float time;
    [SerializeField] private float lerpTime;

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        OnLerp(col.gameObject);
        Vector3 forceUp = col.transform.up * multiplierUp;
        Vector3 forceRight = col.transform.right * multiplierRight;
        col.GetComponent<Rigidbody2D>().AddForce(forceUp);
        col.GetComponent<Rigidbody2D>().AddForce(forceRight);
    }
    
    public void OnLerp(GameObject lerpObject)
    {
        lerpObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,0), time);
        time += Time.deltaTime * lerpTime;
    }
}
