using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class Create : MonoBehaviour
{

    public InputField Name;
    public InputField Label;

    public string name1;
    public string label1;


    void Update()
    {

        name1 = Name.text;
        label1 = Label.text;
    }

    
}
