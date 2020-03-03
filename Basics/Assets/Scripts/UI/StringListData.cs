﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringListObj;
    public int currentLineNumber;
    
    public string ReturnCurrentLine()
    {
        return stringListObj[currentLineNumber];
    }
    
    public void IncrementLineNumber()
    {
        if (currentLineNumber < stringListObj.Count)
        {
            currentLineNumber++;
        }
        else
        {
            currentLineNumber = 0;
        }
    }
}
