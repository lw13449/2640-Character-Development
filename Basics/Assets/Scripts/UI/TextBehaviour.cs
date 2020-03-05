using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    
    private Text textObj;
    public StringListData stringListDataObj;
    
    void Awake()
    {
        textObj = GetComponent<Text>();
    }
    
    public void UpdateText()
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
        //The only line in our four scripts that connects one to the other. 
    }
}
