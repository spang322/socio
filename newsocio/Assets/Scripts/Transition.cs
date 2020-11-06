using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{

    [SerializeField]
    float transitionSpeed;
    public void Shift(int transition)
    {
        targetShift = new Vector3(0, transition);
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
            rectTransform.anchoredPosition = Vector3.Lerp(rectTransform.anchoredPosition, targetShift, transitionSpeed);
            if (Vector3.Distance(transform.position, targetShift) < 1)
            {
                rectTransform.anchoredPosition = targetShift;
                isShifting = false;
            }
        }
    }
}
