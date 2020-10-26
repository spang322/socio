using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(SceneTransition))]
public class LabelGame : MonoBehaviour
{
    //TODO: красивый переход
    Dictionary<string, string> labels;
    string currentName, currentLabel;
    //Transition transition;
    [SerializeField]
    InputField nameField, labelField;
    [SerializeField]
    GameObject lastPlayerButton, nextPlayerButton;
    SceneTransition sceneTransition;
    void Start()
    {
        labels = new Dictionary<string, string>();
        lastPlayerButton.SetActive(false);
        DontDestroyOnLoad(gameObject);
        sceneTransition = GetComponent<SceneTransition>();
        //transition = GetComponent<Transition>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextPlayer()
    {
        SavePlayer();
        if (labels.Count == 5) 
            lastPlayerButton.SetActive(true);
        if (labels.Count == 11)
            nextPlayerButton.SetActive(false);
    }
    public void LastPlayer()
    {
        SavePlayer();
        sceneTransition.loadScene(2);
    }
    void SavePlayer()
    {
        labels.Add(nameField.text, labelField.text);
        nameField.text = "";
        labelField.text = "";
    }
}
