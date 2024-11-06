using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject disableObject;

    public void DisableThisObject()
    {
        disableObject.SetActive(false);
    }
}
