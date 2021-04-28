using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public static int AAA;
    void Start()
    {
        
        varGiver myVar = GameObject.Find("Main Camera").GetComponent<varGiver>();
        AAA = myVar.DDD;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
