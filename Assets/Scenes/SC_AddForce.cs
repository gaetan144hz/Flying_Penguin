using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AddForce : MonoBehaviour
{
    [SerializeField] float multiplierUp;
    [SerializeField] float multiplierRight;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        Vector3 forceUp = col.transform.up * multiplierUp;
        Vector3 forceRight = col.transform.right * multiplierRight;
        col.GetComponent<Rigidbody2D>().AddForce(forceUp);
        col.GetComponent<Rigidbody2D>().AddForce(forceRight);
    }
}
