using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Spawner : MonoBehaviour
{
    public GameObject banquise;
    [SerializeField] private float b;
    [SerializeField] private float distance;

    void Start()
    {
        b = this.transform.position.x;
        for (int i = 0; i < 5; i++)
        {
            Instantiate(banquise, new Vector3(b,this.transform.position.y,0),Quaternion.identity);
            b += distance;
        }
    }

    void Update()
    {
        
    }
}
