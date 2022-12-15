using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Object = UnityEngine.Object;

public class SC_MoveTest : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public bool canRotate;
    [SerializeField] private float revSpeed;
    private float _inputValue;
    [SerializeField] private GameObject gameover;

    void Start()
    {
        gameover.SetActive(false);
        canRotate = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ManageRotation();
    }

    void Update()
    {

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

    private void OnDestroy()
    {
        gameover.SetActive(true);
    }
}
