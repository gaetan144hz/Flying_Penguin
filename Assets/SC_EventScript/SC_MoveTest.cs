using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SC_MoveTest : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canRotate;
    [SerializeField] private float revSpeed;
    private float _inputValue;
    [SerializeField] private float raycastMaxDistance;
    [SerializeField] private LayerMask _layerMask;

    void Start()
    {
        canRotate = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ManageRotation();
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, raycastMaxDistance, _layerMask);
        
        Debug.DrawRay(transform.position, transform.up * raycastMaxDistance, Color.magenta);

        if (hit.collider != null)
        {
            Debug.Log("touché !", hit.collider.gameObject);
            Destroy(hit.collider.gameObject);
        }
    }
    
    private void ManageRotation()
    {
        if (!canRotate)
            return;
        rb.MoveRotation(rb.rotation + revSpeed * Time.fixedDeltaTime * _inputValue);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        _inputValue = ctx.ReadValue<float>();
        canRotate = ctx.performed; //si appui sur touche il peut rotate
    }
}
