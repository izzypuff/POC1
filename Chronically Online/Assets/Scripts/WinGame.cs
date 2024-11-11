using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    //good endings start at 0
    public int goodending = 0;


    [Header("Timer")]
    private float endTimer = 0F;

    // Update is called once per frame
    void Update()
    {
        //if all 3 goodendings are reached
        if (goodending == 3)
        {
            //start timer to die
            endTimer += Time.deltaTime;
        }


        //once timer reaches 4 
        if (endTimer > 4.0F)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
