using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_BanquiseSpawn : MonoBehaviour
{
    
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject transformRef;
    [SerializeField] private GameObject prefabToSpawn;
    private Vector3 spawnPosition;
    private float length;


    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transformRef.transform.position;
        length = parent.GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SpawnBanquise"))
        {
            spawnPosition.x = other.transform.position.x + length;

            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

        }
    }
}
