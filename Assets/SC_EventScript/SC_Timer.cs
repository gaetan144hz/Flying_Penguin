using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class SC_Timer : MonoBehaviour
{
    public float sec;
    public float min;
    public float currentTime;
    [SerializeField] float startingTime;

    [SerializeField] TextMeshProUGUI[] countdownText;

    void Awake()
    {
        sec = startingTime;
    }

    private void Start()
    {
        timeInstantiate();
    }

    private void Update()
    {
        
    }

    public void timeInstantiate()
    {
        StartCoroutine(timeCount());
    }

    IEnumerator timeCount()
    {
        sec = 0;
        min = 0;
        currentTime = 0;

        while (true)
        {
            sec += 1;
            currentTime += 1;
            if (sec >= 60)
            {
                sec = 0;
                min += 1;
            }

            if (sec <= 9)
            {
                countdownText[0].text = $"Time: {min}min {sec}sec";
                //countdownText[1].text = $"en {min}min {sec}sec";
            }
            else
            {
                countdownText[0].text = $"Time: {min}min {sec}sec";
                //countdownText[1].text = $"en {min}min {sec}sec";
            }
            yield return new WaitForSeconds(1);
        }
    }
}