using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Score : MonoBehaviour
{
    public TextAsset InkJSONFile;

    private Story localStory;


    // Start is called before the first frame update
    void Start()
    {
        localStory = new Story(InkJSONFile.text);

        
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
