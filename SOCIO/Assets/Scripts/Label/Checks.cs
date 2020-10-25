using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks : MonoBehaviour
{
    public int sumbuttons;
    public int f;
    void Start()
    {
        f = (GameObject.Find("Save").GetComponent<Saves>().savename).Count;
        
    }
    
    void Update()
    {
        switch (f)
        {
            case 6:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i;
                
                break;
            case 7:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i;

                break;
            case 8:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i + GameObject.Find("8").GetComponent<ActiveButton>().i;
                break;
            case 9:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i + GameObject.Find("8").GetComponent<ActiveButton>().i + GameObject.Find("9").GetComponent<ActiveButton>().i;
                
                break;
            case 10:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i + GameObject.Find("8").GetComponent<ActiveButton>().i + GameObject.Find("9").GetComponent<ActiveButton>().i + GameObject.Find("10").GetComponent<ActiveButton>().i;
                
                break;
            case 11:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i + GameObject.Find("8").GetComponent<ActiveButton>().i + GameObject.Find("9").GetComponent<ActiveButton>().i + GameObject.Find("10").GetComponent<ActiveButton>().i + GameObject.Find("11").GetComponent<ActiveButton>().i;
                
                break;
            case 12:
                sumbuttons = GameObject.Find("1").GetComponent<ActiveButton>().i + GameObject.Find("2").GetComponent<ActiveButton>().i + GameObject.Find("3").GetComponent<ActiveButton>().i + GameObject.Find("4").GetComponent<ActiveButton>().i + GameObject.Find("5").GetComponent<ActiveButton>().i + GameObject.Find("6").GetComponent<ActiveButton>().i + GameObject.Find("7").GetComponent<ActiveButton>().i + GameObject.Find("8").GetComponent<ActiveButton>().i + GameObject.Find("9").GetComponent<ActiveButton>().i + GameObject.Find("10").GetComponent<ActiveButton>().i + GameObject.Find("11").GetComponent<ActiveButton>().i + GameObject.Find("12").GetComponent<ActiveButton>().i;
                
                break;
            


        }
        
    }
}
