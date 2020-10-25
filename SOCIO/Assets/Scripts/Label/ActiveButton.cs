using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveButton : MonoBehaviour
{

    public int i = 0;
    public int poryadoc;
    int f;

    void Start()
    {
        f = (GameObject.Find("Save").GetComponent<Saves>().savename).Count;
        

    }

    void OnMouseUpAsButton() {

        this.gameObject.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        i += 1;

        if (f == 6)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
            }

        }
        else if (f == 7)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                    }
                    break;
            }
        }
        else if (f == 8)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "8":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                    }
                    break;


            }
        }
        else if (f == 9)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "8":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "9":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                    }
                    break;

            }
        }
        else if (f == 10)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "8":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "9":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "10":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                    }
                    break;

            }

        }
        else if (f == 11)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "8":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "9":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "10":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                    }
                    break;

                case "11":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                    }
                    break;
            }

        }
        else if (f == 12)
        {
            switch (gameObject.name)
            {
                case "1":

                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text1").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "2":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text2").GetComponent<Text>().text;
                            break;

                    }
                    break;

                case "3":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text3").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "4":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text4").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "5":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text5").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "6":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text6").GetComponent<Text>().text;
                            break;

                    }
                    break;
                case "7":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text7").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Tex7").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "8":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text8").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "9":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text9").GetComponent<Text>().text;
                            break;
                    }
                    break;
                case "10":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text10").GetComponent<Text>().text;
                            break;
                    }
                    break;

                case "11":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text11").GetComponent<Text>().text;
                            break;
                    }
                    break;

                case "12":
                    switch (GameObject.Find("Denis").GetComponent<Checks>().sumbuttons)
                    {
                        case 0:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel1 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 1:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel2 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 2:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel3 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 3:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel4 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 4:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel5 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 5:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel6 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 6:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel7 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 7:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel8 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 8:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel9 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 9:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel10 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 10:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel11 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;
                        case 11:
                            GameObject.Find("Save").GetComponent<Saves>().fakelabel12 = GameObject.Find("Text12").GetComponent<Text>().text;
                            break;

                    }
                break;
            }
        }



    } 
}
