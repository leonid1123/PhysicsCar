using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class scoreCont : MonoBehaviour
{
    public int[] scores = new int[3];
    public string[] names = new string[3];

 
    void Start()
    {
        /*for (var i = 0; i < scores.Length; i++)
        {
            WriteString(scores[i].ToString()+" "+names[i]);
           // WriteString(names[i]);
        }*/
        ReadString();
        for (var i = 0; i < 3; i++)
        {
            Debug.Log(names[i]+" "+scores[i].ToString() );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //[MenuItem("Tools/Write file")]
    static void WriteString(string str)
    {
        string path = "Assets/Resources/score.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(str);
        writer.Close();
    }
    void ReadString()
    {
        Debug.Log("read start");
        string path = "Assets/Resources/score.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        int i=0;
        while(reader.Peek()>=0) 
        {
            scores[i] = int.Parse(reader.ReadLine());
            names[i] = reader.ReadLine();
            i++;
            //Debug.Log(reader.ReadLine());
        }
        reader.Close();
        Array.Sort(scores,names);
        Array.Reverse(scores);
        Array.Reverse(names);
    }
}
