using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SC_Cheat : MonoBehaviour
{
    private SC_Score _score;
    [SerializeField] private float lerpTime;
    public bool lerpBool;
    [SerializeField] private float time;

    void Start()
    {
        lerpBool = false;
        _score = this.gameObject.GetComponent<SC_Score>();
    }

    void Update()
    {
        if (!lerpBool)
            return;
        OnLerp();
    }
    
    public void OnAddScore(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            _score.score += 100;
            Debug.Log("Score +100");
        }
    }

    public void OnRemoveScore(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            _score.score -= 100;
            Debug.Log("Score -100");
        }
    }

    public void OnGOD(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            _score.score = 9999999;
            Debug.Log("Score set 9999999");
        }
    }

    public void OnLerp()
    {
        this.gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0,90), time);
        time += Time.deltaTime / lerpTime;
    }

    public void OnLerpTest(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
            return;
        lerpBool = true;
        Debug.Log("Lerp !");
    }
}
