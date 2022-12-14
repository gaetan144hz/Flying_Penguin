using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SC_Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
