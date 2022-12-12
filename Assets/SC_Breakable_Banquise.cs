using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SC_Breakable_Banquise : MonoBehaviour
{
    public int breakable;
    public TextMeshProUGUI textBreaker;
        
    void Start()
    {
        textBreaker.text = breakable.ToString();
    }

    void Update()
    {
        
    }
}
