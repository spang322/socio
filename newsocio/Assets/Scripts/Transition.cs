using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{

    public void Shift(int transition)
    {
        targetShift = new Vector3(transition,0);
        isShifting = true;
    }
    Vector3 targetShift;
    bool isShifting;
    RectTransform rectTransform;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (isShifting)
        {
            rectTransform.anchoredPosition = Vector3.Lerp(rectTransform.anchoredPosition, targetShift, 0.3f);
            if (Vector3.Distance(transform.position, targetShift) < 1)
            {
                rectTransform.anchoredPosition = targetShift;
                isShifting = false;
            }
        }
    }
}
