using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    
    private Text textObj;
    public StringListData stringListDataObj;
    
    // Start is called before the first frame update
    void Awake()
    {
        textObj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textObj.text = stringListDataObj.ReturnCurrentLine();
    }
}
