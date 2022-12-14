using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SC_Penguin_Behaviour : MonoBehaviour
{
    private new Rigidbody2D rb2D;
    private float direction;
    [SerializeField] private float TurningRate;
    [SerializeField] private float LaunchForce;
    private bool canRotate;
    [SerializeField] private float Thrust;



    // Update is called once per frame
    void Awake()
    {
        canRotate = false;
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ManageRotation();
        //rb2D.AddForce(transform.up * Thrust, ForceMode2D.Impulse);
    }

    private void ManageRotation()
    {
        if (!canRotate)
            return;
        rb2D.MoveRotation(rb2D.rotation + TurningRate * Time.fixedDeltaTime * direction);
    }

    public void OnRotate(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<float>();
        canRotate = obj.performed;
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ramp"))
        {
            rb2D.AddForce(transform.up * LaunchForce, ForceMode2D.Impulse);

        }

    }

}
