using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{

    [Header("Dialogue UI")]

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [Header("Chocies UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;

    private static DialogueManager instance;

    public TextAsset InkJSONFile;

    [Header("Score")]
    public int score;
    public GameObject[] bars;

    [Header("Timer")]
    public bool startTimer;
    public float timer = 10;
    public float minTimer = 0;
    public TextMeshProUGUI timerText;

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }

        EnterDialogueMode(InkJSONFile);
    }

    private void Update()
    {
        if (startTimer)
        {
            timer -= Time.deltaTime;
        }

        timerText.text = (timer).ToString("0");

        if(timer < 0)
        {
            score++;
            timer = 10;
        }

        //handle continuing to next line in dialogue when submit is pressed
        //if (InputManager.GetInstance().GetSubmitPressed())
        //{
            ContinueStory();
        //}

        DisplayBar();


    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);

        currentStory.ObserveVariable("anger", (variableName, newValue) =>
        {
            score = (int) newValue;
        });

        ContinueStory();
    }


    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            //set text for current dialogue line
            dialogueText.text = currentStory.Continue();
            //display choices (if any) for this dialogue line
            DisplayChoices();
            startTimer = true;
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        int index = 0;
        //enable and initialize choices up to amount of choices for line of dialogue
        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        timer = 10;
    }

    public void DisplayBar()
    {
       
        foreach (GameObject bar in bars)
        {
            bar.SetActive(false);
        }
        bars[score].SetActive(true);

    }
}
