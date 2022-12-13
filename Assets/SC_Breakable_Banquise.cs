using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SC_Breakable_Banquise : MonoBehaviour
{
    private SC_Score _score;
    public int breakableScore;
    public bool canBreak;
    public TextMeshProUGUI textBreaker;
    [SerializeField] private float lerpTime;
        
    void Start()
    {
        lerpTime = 1.5f;
        canBreak = false;
        _score = FindObjectOfType<SC_Score>();
        textBreaker.text = breakableScore.ToString();
    }

    void Update()
    {
        
        if (_score.score == breakableScore)
        {
            canBreak = true;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Penguin") && canBreak == true)
        {
            _score.score += breakableScore;
            Debug.Log("plouf");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("t mort ta pas assez de score nullos");
            //onLerp(col.gameObject);
        }
    }

    public void onLerp(GameObject lerpObject)
    {
        lerpObject.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,90), lerpTime);
        Debug.Log("t mort ta pas assez de score nullos");
    }
}
