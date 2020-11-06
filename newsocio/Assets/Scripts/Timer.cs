using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

[RequireComponent(typeof(Text))]
public class Timer : MonoBehaviour
{
    Text text;
    [SerializeField]
    float endTime;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        int minutes = Convert.ToInt32(endTime - Time.time) / 60;
        int seconds = Convert.ToInt32(endTime - Time.time) % 60;
        text.text = String.Format("{0:0}:{1:00}", minutes, seconds);
    }

    public void SetTimer(int seconds)
    {
        endTime = Time.time + seconds;
    }
}
