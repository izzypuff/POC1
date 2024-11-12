using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowIndicator : MonoBehaviour
{
    public GameObject arrow;
    private int endOfStory;

    // Start is called before the first frame update
    void Start()
    {
        arrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<DialogueManager>().score = 0;

        endOfStory = GetComponent<DialogueManager>().goodending;

        if(endOfStory == 1)
        {
            arrow.SetActive(true);
        }


    }
}
