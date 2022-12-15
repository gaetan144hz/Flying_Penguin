using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_BanquiseSpawn : MonoBehaviour
{
    
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject spawnTransformRef;
    [SerializeField] private GameObject spawnTransformTrig;
    [SerializeField] private GameObject prefabToSpawn;
    private Vector3 spawnPosition;
    [SerializeField] private float length;


    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = parent.transform.position;
        //length = spawnTransformRef.transform.position.x - spawnTransformTrig.transform.position.x;
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
