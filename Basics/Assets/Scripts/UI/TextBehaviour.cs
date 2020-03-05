﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    
    private Text textObj;
    public UnityEvent awakeEvent;
    
    public void Start()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }
    
    public void UpdateText(StringListData stringListDataObj)
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }
    public void UpdateText(IntData intDataObj)
    {
        textObj.text = intDataObj.value.ToString();
    }
}
