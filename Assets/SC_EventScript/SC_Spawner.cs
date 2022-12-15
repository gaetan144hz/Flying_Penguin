using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Spawner : MonoBehaviour
{
    public GameObject banquise;
    [SerializeField] private float lastDistance;
    [SerializeField] private float addDistance;
    [SerializeField] private int banquiseNumber;

    void Start()
    {
        lastDistance = this.transform.position.x;
        for (int i = 0; i < banquiseNumber; i++)
        {
            Instantiate(banquise, new Vector3(lastDistance,this.transform.position.y,0),Quaternion.identity);
            lastDistance += addDistance;
        }
    }

    void Update()
    {
        
    }
}
