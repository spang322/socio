using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class Error1 : MonoBehaviour
{

    public InputField Field;
    
    public int nim;
    
    void Update()
    {
    
        nim = Convert.ToInt32(Field.text);
    }
    
}
