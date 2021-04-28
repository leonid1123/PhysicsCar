using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textWriter : MonoBehaviour
{

    Text text;
    void Start()
    {
        WriteText();
    }

    
    void WriteText()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
        scoreCont scoreController = GameObject.Find("GameObject").GetComponent<scoreCont>();
        for (var i = 0; i < scoreController.scores.Length; i++)
        {
            text.text += (scoreController.scores[i].ToString()+" "+scoreController.names[i] +System.Environment.NewLine);
        }
        
    }
}
