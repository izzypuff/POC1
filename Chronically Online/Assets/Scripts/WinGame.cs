using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    //good endings start at 0
    public int goodending = 0;

    // Update is called once per frame
    void Update()
    {
        //if all 3 goodendings are reached
        if (goodending == 3)
        {
            //use scene manager to load game scene
            SceneManager.LoadScene("Win");
        }
    }
}
