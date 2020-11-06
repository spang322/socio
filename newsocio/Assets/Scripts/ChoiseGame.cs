using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(CardGenerator))]
public class ChoiseGame : MonoBehaviour
{
    List<string> names;
   
    [SerializeField]
    int maxPlayers, minPlayers;
    
    [SerializeField]
    InputField nameField;
    [SerializeField]
    Button lastPlayerButton, nextPlayerButton;
    [SerializeField]
    Text nextPlayerButtonText;
    SceneTransition sceneTransition;
    CardGenerator cardGenerator;
    Timer timer;
    [SerializeField]
    


    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void Start()
    {
        names = new List<string>();
        lastPlayerButton.gameObject.SetActive(false);
        nextPlayerButtonText.text = "Заполните поля";
        nextPlayerButton.interactable = false;
        DontDestroyOnLoad(gameObject);
        sceneTransition = GetComponent<SceneTransition>();
        cardGenerator = GetComponent<CardGenerator>();

    }
    bool generateCards = false;
    public void NextPlayer()
    {
        SavePlayer();
        if (names.Count == minPlayers - 1)
            lastPlayerButton.gameObject.SetActive(true);
        if (names.Count == maxPlayers - 1)
            nextPlayerButton.gameObject.SetActive(false);
    }
    void SavePlayer()
    {
        names.Add(nameField.text);
        nameField.text = "";
        
    }

    public void LastPlayer()
    {
        SavePlayer();
        generateCards = true;
        sceneTransition.loadScene(4);
    }

    public void OnTextFieldsChanged()
    {

        if (names.Contains(nameField.text))
            ChangeButtons(false, "Это имя уже занято");
        else if (nameField.text == "")
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

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        /*
         * if (generateCards)
        {
            
            timer = FindObjectOfType<Timer>();
            timer.SetTimer(30 * names.Count);
        }
        */
    }

}
