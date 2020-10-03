using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    int z = 1;
    public int f;
    
    
    


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
                f = GameObject.Find("MainCamera").GetComponent<Error1>().nim;

                if (f > 5 && f < 10)
                {
                    
                    SceneManager.LoadScene("PlayFirst");
                    break;
                }
                break;


        }
    }
}