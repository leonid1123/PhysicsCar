using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textWriter : MonoBehaviour
{
    int[] score={1,2,3,4};
    Text text;
    void Start()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
        for (var i = 0; i < score.Length; i++)
        {
            text.text += (score[i].ToString()+System.Environment.NewLine);
        }
    }

    
    void Update()
    {
        
    }
}
