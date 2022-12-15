using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SC_DisctanceScore : MonoBehaviour
{
    public GameObject startPos;
    public TextMeshProUGUI scoreText;

    private float distance;
    
    void Start()
    {
    }

    void Update()
    {
        distance = (startPos.transform.position.x + this.transform.position.x);
        scoreText.text = distance.ToString("F1") + "M";
    }
}
