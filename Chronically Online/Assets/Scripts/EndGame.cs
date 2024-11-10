using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject finalBar;
    public string nextScene;
    public bool badending = false;

    [Header("Timer")]
    private float endTimer = 0F;

    // Update is called once per frame
    void Update()
    {
        //if anger max is reached or bad ending happens
        if ((finalBar.activeSelf == true) || (badending == true))
        {
            //show final bar to indicate death
            finalBar.SetActive(true);
            //start timer to die
            endTimer += Time.deltaTime;
        }

        //once timer reaches 4 
        if (endTimer > 4.0F)
        {
            //load game
            LoadGame(nextScene);
        }
    }

    //load bad ending based on which bad ending reached
    public void LoadGame(string sceneToLoad)
    {
        //use scene manager to load game scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
