using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_TimeToDestroy : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;

    void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }

    void Update()
    {
        
    }
}
