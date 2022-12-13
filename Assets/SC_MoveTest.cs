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

    void Start()
    {
        canRotate = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ManageRotation();
    }

    private void ManageRotation()
    {
        if (!canRotate)
            return;
        rb.MoveRotation(rb.rotation + revSpeed * Time.fixedDeltaTime * _inputValue);
    }

    void Update()
    {

    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        _inputValue = ctx.ReadValue<float>();
        canRotate = ctx.performed;
    }
}
