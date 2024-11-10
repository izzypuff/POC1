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

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    public Story currentStory;

    private static DialogueManager instance;

    public TextAsset InkJSONFile;

    [Header("Score")]
    private int angerScore;
    private int score = 0;
    public GameObject[] bars;

    [Header("Endings")]
    public GameObject Manager;
    private int badending;
    private int goodending;
    private bool goodendingAdd = false;
    private bool removeTimer = false;

    [Header("Timer")]
    private bool startTimer;
    private float timer = 10;
    private float minTimer = 0;
    public TextMeshProUGUI timerText;

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    public void Start()
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

    public void Update()
    {

        //start choice timer
        if (startTimer)
        {
            //decreasing timer
            timer -= Time.deltaTime;
        }

        //set timer text to display time remaining
        timerText.text = (timer).ToString("0");

        //if a ink story reaches good ending
        if(goodending == 1)
        {
            //stop timer
            startTimer = false;
            //increment goodending int in sep script
            goodendingAdd = true;
        }
        
        if(goodendingAdd == true)
        {
            //reset goodending variables
            goodending = 0;
            goodendingAdd = false;
            //remove timer
            removeTimer = true;
            //add 1 to goodending in other script
            Manager.GetComponent<WinGame>().goodending += 1;
        }

        //remove timer
        if(removeTimer == true)
        {
            //get rid of timer text
            timerText.text = "";
        }

        //if bad ending
        if(badending == 1)
        {
            //bad ending bool in sep script is true, ending game
            GetComponent<EndGame>().badending = true;
        }

        //continue story
        ContinueStory();

        //display anger bar
        DisplayBar();
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);

        //observe anger variable
        currentStory.ObserveVariable("anger", (variableName, newValue) =>
        {
            score = (int)newValue;
        });

        //observe whether story has bad ending through int in ink
        currentStory.ObserveVariable("badending", (variableName, newValue) =>
        {
            badending = (int)newValue;
        });

        //observe whether story has good ending through int in ink
        currentStory.ObserveVariable("goodending", (variableName, newValue) =>
        {
            goodending = (int)newValue;
        });

        //continue the story
        ContinueStory();
    }


    public void ContinueStory()
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

    public void DisplayChoices()
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
            //set choices to false
            choices[i].gameObject.SetActive(false);
        }
    }

    public void MakeChoice(int choiceIndex)
    {
        //make choice based on index
        currentStory.ChooseChoiceIndex(choiceIndex);
        //reset choice timer
        timer = 10;
    }

    public void DisplayBar()
    {
        //for each gameobject bar in the array
        foreach (GameObject bar in bars)
        {
            //set the gameobject to inactive
            bar.SetActive(false);
        }

        //if timer reaches 0
        if (timer < 0)
        {
            //add to score
            score++;
            //reset timer
            timer = 10;
        }

        //if score is negative
        if (score < 0)
        {
            //set score to 0
            score = 0;
        }

        //set gameobject relating to score active
        bars[score].SetActive(true);
    }
}
