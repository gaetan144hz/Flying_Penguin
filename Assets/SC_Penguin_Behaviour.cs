using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SC_Penguin_Behaviour : MonoBehaviour
{
    private new Rigidbody2D rb2D;
    [SerializeField] private float LaunchForce;
    


    // Update is called once per frame
    void Awake()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ramp"))
        {
            rb2D.AddForce(transform.up * LaunchForce, ForceMode2D.Impulse);

        }

    }

}
