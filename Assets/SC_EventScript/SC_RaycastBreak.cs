using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_RaycastBreak : MonoBehaviour
{
        
    [Header("Raycast Settings")]
    [SerializeField] private float raycastMaxDistance1;
    [SerializeField] private LayerMask _layerMask;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(transform.position, transform.up, raycastMaxDistance1, _layerMask);

        Debug.DrawRay(transform.position, transform.up * raycastMaxDistance1, Color.magenta);
        
        if (hit1.collider != null)
        {
            Debug.Log("touché !", hit1.collider.gameObject);
            Destroy(hit1.collider.gameObject);
        }
    }
}
