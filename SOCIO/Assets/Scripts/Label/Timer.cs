using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float timeStart = 59;
    public int minute;
    public float timeEnd = 20;

    public Text min;
    public Text timerText;
    public Text text;
    public Text text2;
    bool ptov = true;



    public int z;

    void Start()
    {
        z = GameObject.Find("MainCamera").GetComponent<PlayLabel>().count; //достаю число игроков
        
        
        switch (z)
        {
            case 6:
                minute = 2;
                break;
            case 7:
                minute = 3;
                timeStart = 30;
                break;
            case 8:
                minute = 3;
                break;
            case 9:
                minute = 4;
                timeStart = 30;
                break;
            case 10:
                minute = 5;
                break;
            case 11:
                minute = 5;
                timeStart = 30;
                break;
            case 12:
                minute = 5;
                break;
           
        }
        
        timerText.text = timeStart.ToString();
        min.text = minute.ToString();
    }

    

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();
        
        if (timeStart < 9.5)
        {
            GameObject.Find("Zero").GetComponent<Text>().enabled = true;
            GameObject.Find("Second").GetComponent<RectTransform>().transform.position = new Vector2(2.67f, -4.89f);
        }
        else
        {
            GameObject.Find("Zero").GetComponent<Text>().enabled = false;
            GameObject.Find("Second").GetComponent<RectTransform>().transform.position = new Vector2(2.40f, -4.89f);
        }


        if (timeStart < 0 && minute > 1)
        {
            timeStart = 59;
            minute -= 1;
            
            min.text = minute.ToString();
            
        }
        else if ((min.text == "0" || min.text == " ")  && timeStart <= 0)
        {
            GameObject.Find("Panel").GetComponent<Animator>().enabled = true;
            ptov = false;
            timerText.text = " ";
            text.text = " ";
            text2.text = " ";
            min.text = " "; 
            timeEnd -= Time.deltaTime;
            if (timeEnd < -1)
            {
                SceneManager.LoadScene("Scene2");
            }
        }
        else if (timeStart < 0 && minute == 1 && ptov == true)
        {
            timeStart = 59;
            min.text = "0";
        }
        
        
    }
    
}
