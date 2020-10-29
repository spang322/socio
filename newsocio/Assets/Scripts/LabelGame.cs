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
    int maxPlayers, minPlayers;
    [SerializeField]
    InputField nameField, labelField;
    [SerializeField]
    Button lastPlayerButton, nextPlayerButton;
    [SerializeField]
    Text nextPlayerButtonText;
    SceneTransition sceneTransition;

    void Start()
    {
        labels = new Dictionary<string, string>();
        lastPlayerButton.gameObject.SetActive(false);
        nextPlayerButtonText.text = "Заполните поля";
        nextPlayerButton.interactable = false;
        DontDestroyOnLoad(gameObject);
        sceneTransition = GetComponent<SceneTransition>();
        //transition = GetComponent<Transition>();
    }

    public void NextPlayer()
    {
        SavePlayer();
        if (labels.Count == minPlayers - 1)
            lastPlayerButton.gameObject.SetActive(true);
        if (labels.Count == maxPlayers - 1)
            nextPlayerButton.gameObject.SetActive(false);
    }

    public void LastPlayer()
    {
        SavePlayer();
        sceneTransition.loadScene(2);
    }

    public void OnTextFieldsChanged()
    {
        
        if (labels.ContainsKey(nameField.text))
            ChangeButtons(false, "Это имя уже занято");
        else if (labels.ContainsValue(labelField.text))
            ChangeButtons(false, "Такой ярлык уже придумали");
        else if (nameField.text == "" || labelField.text == "")
            ChangeButtons(false, "Заполните поля");
        else
            ChangeButtons(true, "Продолжить");

    }

    void ChangeButtons(bool interactable, string buttonText)
    {
        nextPlayerButtonText.text = buttonText;
        nextPlayerButton.interactable = interactable;
        lastPlayerButton.interactable = interactable;
    }

    void SavePlayer()
    {
        labels.Add(nameField.text, labelField.text);
        nameField.text = "";
        labelField.text = "";
    }

}
