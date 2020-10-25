using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Saves : MonoBehaviour
{
    public List<string> savenum = new List<string>();
    public List<string> savename = new List<string>();
    public int nomername;
    
    
    

    


    

    public string fakelabel1;
    public string fakelabel2;
    public string fakelabel3;
    public string fakelabel4;
    public string fakelabel5;
    public string fakelabel6;
    public string fakelabel7;
    public string fakelabel8;
    public string fakelabel9;
    public string fakelabel10;
    public string fakelabel11;
    public string fakelabel12;




    void Start()
    {

        
        

        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label1);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label2);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label3);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label4);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label5);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label6);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label7);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label8);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label9);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label10);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label11);
        savenum.Add(GameObject.Find("Ready").GetComponent<Buttons>().label12);

        for (int i = 0; i < savenum.Count; i++)
        {
            if (savenum[i] == "0" || savenum[i] == "")
            {
                savenum.Remove(savenum[i]);
                i--;
            }

        }

        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().first);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().second);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().third);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().fourth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().fifth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().sixth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().seventh);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().eighth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().ninth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().tenth);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().eleventh);
        savename.Add(GameObject.Find("Ready").GetComponent<Buttons>().tvelvth);

        for (int i = 0; i < savename.Count; i++)
        {
            if (savename[i] == "0" || savename[i] == "")
            {
                savename.Remove(savename[i]);
                i--;
            }

        }








        
            
         GameObject.Find("Text1").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
            
         for (int i = 0; i < savenum.Count; i++)
            {
             if (savenum[i] == GameObject.Find("Text1").GetComponent<Text>().text)
             {
                savenum.Remove(savenum[i]);
                i--;
             }

         }

         GameObject.Find("Text2").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
         for (int i = 0; i < savenum.Count; i++)
         {
             if (savenum[i] == GameObject.Find("Text2").GetComponent<Text>().text)
             {
                savenum.Remove(savenum[i]);
                i--;
             }

         }

         GameObject.Find("Text3").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
         for (int i = 0; i < savenum.Count; i++)
         {
            if (savenum[i] == GameObject.Find("Text3").GetComponent<Text>().text)
            {
               savenum.Remove(savenum[i]);
               i--;
            }

         }

         GameObject.Find("Text4").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
         for (int i = 0; i < savenum.Count; i++)
         {
             if (savenum[i] == GameObject.Find("Text4").GetComponent<Text>().text)
             {
                savenum.Remove(savenum[i]);
                i--;
             }

         }

         GameObject.Find("Text5").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
         for (int i = 0; i < savenum.Count; i++)
         {
            if (savenum[i] == GameObject.Find("Text5").GetComponent<Text>().text)
            {
                savenum.Remove(savenum[i]);
                i--;
            }

         }

         switch (savename.Count)
         {
            case 6:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[0];
                break;
            case 7:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[0];
                break;
            case 8:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                     if (savenum[i] == GameObject.Find("Text7").GetComponent<Text>().text)
                     {
                         savenum.Remove(savenum[i]);
                         i--;
                     }

                }
                GameObject.Find("Text8").GetComponent<Text>().text = savenum[0];
                break;
            case 9:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[0];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                     if (savenum[i] == GameObject.Find("Text7").GetComponent<Text>().text)
                     {
                         savenum.Remove(savenum[i]);
                         i--;
                     }

                }
                GameObject.Find("Text8").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                     if (savenum[i] == GameObject.Find("Text8").GetComponent<Text>().text)
                     {
                        savenum.Remove(savenum[i]);
                        i--;
                     }

                }
                GameObject.Find("Text9").GetComponent<Text>().text = savenum[0];
                break;
            case 10:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text7").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text8").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text8").GetComponent<Text>().text)
                    {
                       savenum.Remove(savenum[i]);
                       i--;
                    }

                }
                GameObject.Find("Text9").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text9").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text10").GetComponent<Text>().text = savenum[0];
                break;
            case 11:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text7").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text8").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text8").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text9").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                     if (savenum[i] == GameObject.Find("Text9").GetComponent<Text>().text)
                     {
                         savenum.Remove(savenum[i]);
                         i--;
                     }

                }
                GameObject.Find("Text10").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text10").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text11").GetComponent<Text>().text = savenum[0]; 
                break;
            case 12:
                GameObject.Find("Text6").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text6").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text7").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                     if (savenum[i] == GameObject.Find("Text7").GetComponent<Text>().text)
                     {
                         savenum.Remove(savenum[i]);
                         i--;
                     }

                }
                GameObject.Find("Text8").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text8").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text9").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text9").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text10").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text10").GetComponent<Text>().text)
                    {
                        savenum.Remove(savenum[i]);
                        i--;
                    }

                }
                GameObject.Find("Text11").GetComponent<Text>().text = savenum[UnityEngine.Random.Range(0, savenum.Count)];
                for (int i = 0; i < savenum.Count; i++)
                {
                    if (savenum[i] == GameObject.Find("Text11").GetComponent<Text>().text)
                    {
                       savenum.Remove(savenum[i]);
                       i--;
                    }

                }
                GameObject.Find("Text12").GetComponent<Text>().text = savenum[0];
                break;


                
         }
            
        
    }
    void Update()
    {
        //Имя
            
        
        nomername = GameObject.Find("Denis").GetComponent<Checks>().sumbuttons;

        if (GameObject.Find("nametext").GetComponent<Text>().text != savename[savename.Count - 1])
        {
            GameObject.Find("nametext").GetComponent<Text>().text = savename[nomername];

        }
        else
        {
            nomername += 1;
        }
        
        if (nomername == savename.Count + 1)
        {
            //SceneManager.LoadScene("Scene1");
        }
        


    }
}