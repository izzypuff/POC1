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
    public GameObject bar0;
    public GameObject bar1;
    public GameObject bar2;
    public GameObject bar3;


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

        //handle continuing to next line in dialogue when submit is pressed
        //if (InputManager.GetInstance().GetSubmitPressed())
        //{
            ContinueStory();
        //}

        if(score == 0)
        {
            bar0.SetActive(true);
            bar1.SetActive(false);
            bar2.SetActive(false);
            bar3.SetActive(false);
        }

        if(score == 1)
        {
            bar0.SetActive(false);
            bar1.SetActive(true);
            bar2.SetActive(false);
            bar3.SetActive(false);
        }

        if (score == 2)
        {
            bar0.SetActive(false);
            bar1.SetActive(false);
            bar2.SetActive(true);
            bar3.SetActive(false);
        }

        if (score == 3)
        {
            bar0.SetActive(false);
            bar1.SetActive(false);
            bar2.SetActive(false);
            bar3.SetActive(true);
        }
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
    }
}
