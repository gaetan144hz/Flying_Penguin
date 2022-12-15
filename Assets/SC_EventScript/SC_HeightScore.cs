using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class SC_HeightScore : MonoBehaviour
{
    public GameObject startPos;
    public TextMeshProUGUI scoreText;

    private float height;
    
    void Start()
    {

    }

    void Update()
    {
        height = (startPos.transform.position.y + this.transform.position.y);
        scoreText.text = height.ToString("F1") + "H";
    }
}
