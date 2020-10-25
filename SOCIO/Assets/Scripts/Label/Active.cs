using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Active : MonoBehaviour
{
    public int b;

    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;

    public List<string> list = new List<string>();




    void Start()
    {
        b = GameObject.Find("MainCamera").GetComponent<PlayLabel>().count;

        list = GameObject.Find("MainCamera").GetComponent<PlayLabel>().numbers;

        if (b == 6)
        {
            obj6.SetActive(true);
            GameObject.Find("Text1").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }
                
            }

            GameObject.Find("Text2").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text3").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text4").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text5").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text6").GetComponent<Text>().text = list[0];
        }
        else if (b == 7) {
            obj7.SetActive(true);

            GameObject.Find("Text1(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(7)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(7)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(7)").GetComponent<Text>().text = list[0];

        }
        else if (b == 8)
        {
            obj8.SetActive(true);

            GameObject.Find("Text1(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(8)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text7(8)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text8(8)").GetComponent<Text>().text = list[0];
        }
        else if (b == 9)
        {
            obj9.SetActive(true);

            GameObject.Find("Text1(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text7(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text8(9)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text8(9)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text9(9)").GetComponent<Text>().text = list[0];
        }
        else if (b == 10)
        {
            obj10.SetActive(true);

            GameObject.Find("Text1(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text7(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text8(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text8(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text9(10)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text9(10)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text10(10)").GetComponent<Text>().text = list[0];
        }
        else if (b == 11)
        {
            obj11.SetActive(true);

            GameObject.Find("Text1(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text7(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text8(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text8(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text9(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text9(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text10(11)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text10(11)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text11(11)").GetComponent<Text>().text = list[0];
        }
        else
        {
            obj12.SetActive(true);

            GameObject.Find("Text1(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text1(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text2(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text2(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text3(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text3(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text4(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text4(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text5(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text5(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }
            GameObject.Find("Text6(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text6(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text7(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text7(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text8(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text8(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text9(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text9(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text10(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text10(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text11(12)").GetComponent<Text>().text = list[UnityEngine.Random.Range(0, list.Count)];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == GameObject.Find("Text11(12)").GetComponent<Text>().text)
                {
                    list.Remove(list[i]);
                    i--;
                }

            }

            GameObject.Find("Text12(12)").GetComponent<Text>().text = list[0];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}