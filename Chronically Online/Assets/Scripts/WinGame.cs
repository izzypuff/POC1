using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{

    public int goodending = 0;

    // Update is called once per frame
    void Update()
    {
        if (goodending == 3)
        {
            //use scene manager to load game scene
            SceneManager.LoadScene("Win");
        }
    }
}
