using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SC_Cheat : MonoBehaviour
{
    private SC_Score _score;
    [SerializeField] private float lerpTime;
    [SerializeField] private bool lerpBool;
    [SerializeField] private float time;
    
    void Start()
    {
        lerpBool = false;
        _score = this.gameObject.GetComponent<SC_Score>();
    }

    void Update()
    {
        if (lerpBool == true)
        {
            OnLerp();
        }
        else
        {
            return;
        }
    }
    
    public void OnAddScore(InputValue value)
    {
        if (value.isPressed)
        {
            _score.score += 100;
            Debug.Log("Score +100");
        }
    }

    public void OnRemoveScore(InputValue value)
    {
        if (value.isPressed)
        {
            _score.score -= 100;
            Debug.Log("Score -100");
        }
    }

    public void OnGOD(InputValue value)
    {
        if (value.isPressed)
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

    public void OnLerpTest(InputValue value)
    {
        if (value.isPressed)
        {
            lerpBool = true;
            Debug.Log("Lerp !");
        }
    }
}
