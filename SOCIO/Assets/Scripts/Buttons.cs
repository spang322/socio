using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    int z = 1;
    public int f;
    int number = 0;

    public string first;
    public string label1;

    public string second;
    public string label2;

    public string third;
    public string label3;

    public string fourth;
    public string label4;

    public string fifth;
    public string label5;

    public string sixth;
    public string label6;

    public string seventh;
    public string label7;

    public string eighth;
    public string label8;

    public string ninth;
    public string label9;

    public string tenth;
    public string label10;

    public string eleventh;
    public string label11;

    public string tvelvth;
    public string label12;



    public InputField Label;
    public InputField Name;




    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene("Play");
                break;
            case "PlayOnline":
                SceneManager.LoadScene("PlayOnline");
                break;
            case "Voice":
                if (z == 1)
                {
                    GameObject.Find("sound").GetComponent<AudioSource>().Pause();
                    z = 0;
                    break;
                }
                else
                {
                    GameObject.Find("sound").GetComponent<AudioSource>().Play();
                    z = 1;
                    break;
                }
            case "Back":
                SceneManager.LoadScene(0);
                break;
            case "GameFirst":
                SceneManager.LoadScene("GameFirst");
                break;
            case "Done":
                f = GameObject.Find("Chislo").GetComponent<Error1>().nim;

                if (f > 5 && f < 13)
                {

                    SceneManager.LoadScene("PlayFirst");
                    break;
                }
                break;

            case "Ready":
                
                number += 1;
                
                if (number == 1)
                {
                    first = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label1 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    break;
                }
                if (number == 2)
                {
                    second = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label2 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    break;
                }
                if (number == 3)
                {
                    third = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label3 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    break;
                }
                if (number == 4)
                {
                    fourth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label4 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    break;
                }
                if (number == 5)
                {
                    fifth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label5 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    break;
                }
                f = GameObject.Find("Chislo").GetComponent<Error1>().nim;
                if (number == 6)
                {
                    sixth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label6 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 6)
                    {
                        label7=label8=label9=label10=label11=label12 = "0";
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                        
                    }
                    break;
                }
                if (number == 7 && f > 6)
                {
                    seventh = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label7 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 7)
                    {
                        label8 = label9 = label10 = label11 = label12 = "0";
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                if (number == 8 && f > 7)
                {
                    label9 = label10 = label11 = label12 = "0";
                    eighth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label8 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 8)
                    {
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                if (number == 9 && f > 8)
                {
                    ninth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label9 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 9)
                    {
                        label10 = label11 = label12 = "0";
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                if (number == 10 && f > 9)
                {
                    tenth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label10 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 10)
                    {
                        label11 = label12 = "0";
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                if (number == 11 && f > 10)
                {
                    eleventh = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label11 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 11)
                    {
                        label12 = "0";
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                if (number == 12 && f > 11)
                {
                    tvelvth = GameObject.Find("MainCamera").GetComponent<Create>().name1;
                    label12 = GameObject.Find("MainCamera").GetComponent<Create>().label1;

                    Label.text = "";
                    Name.text = "";
                    if (f == 12)
                    {
                        DontDestroyOnLoad(this.gameObject);
                        SceneManager.LoadScene("Scene1");
                    }
                    break;
                }
                break;


        }
    }
}