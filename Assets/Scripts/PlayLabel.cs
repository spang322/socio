using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PlayLabel : MonoBehaviour
{
    public List<string> numbers = new List<string>();
    

    void Start()
    {
        Destroy(GameObject.Find("Chislo"));
        GameObject.Find("Ready").GetComponent<MeshRenderer>().enabled = false;

        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label1);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label2);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label3);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label4);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label5);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label6);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label7);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label8);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label9);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label10);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label11);
        numbers.Add(GameObject.Find("Ready").GetComponent<Buttons>().label12);


        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == "0")
            {
                numbers.Remove(numbers[i]);
                i--;
            }
            
        }

        
        
       


        

        

    }
    // Update is called once per frame
    void Update()
    {

    }
}
