using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ink.Runtime;

public class IntroToMain : MonoBehaviour
{ 

    // Update is called once per frame
    public void OnEndOfStory()
    {
        SceneManager.LoadScene("Main");
    }
}
