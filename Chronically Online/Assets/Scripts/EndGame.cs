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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((finalBar.activeSelf == true) || (badending == true))
        {
            finalBar.SetActive(true);
            endTimer += Time.deltaTime;
        }

        if (endTimer > 4.0F)
        {
            LoadGame(nextScene);
        }
       
    }

    public void LoadGame(string sceneToLoad)
    {
        //use scene manager to load game scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
