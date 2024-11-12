using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarZPos : MonoBehaviour
{
    public float zPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetAsLastSibling();
    }
}
