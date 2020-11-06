using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEditor;
using System;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
    public Text text;
    [SerializeField]
    float endTime;
    bool counting = false;
    public UnityEvent onTimeOut;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        float timeLeft = endTime - Time.time;
        int minutes = Convert.ToInt32(timeLeft) / 60;
        int seconds = Convert.ToInt32(timeLeft) % 60;
        if(timeLeft >= 0)
            text.text = String.Format("{0:0}:{1:00}", minutes, seconds);
        if (minutes == 0 && seconds == 0 && counting)
        {
            onTimeOut.Invoke();
            counting = false;
        }
            
    }

    public void SetTimer(int seconds)
    {
        endTime = Time.time + seconds;
        counting = true;
    }
}
