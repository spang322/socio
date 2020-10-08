using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class Error1 : MonoBehaviour
{

    public InputField Field;
    public static int check;
    public int nim;
    

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }
    void Update()
    {
        if (Field.text != ""){
            nim = Convert.ToInt32(Field.text);
            check = nim;
        }
        
        
        
    }
    
}
