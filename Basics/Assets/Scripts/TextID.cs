using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

//Made By Anthony Romrell

public class TextUi : MonoBehaviour
{
    public InputField dataField;
    public Text dataOutputText;

    public DataStorage nameDataStorage;

    public StringData soData;

    private void Start()
    {
        nameDataStorage.GetData();
        dataOutputText.text = soData.SingleName;
    }

    public void UpdateText()
    {
        soData.SingleName = dataField.text;
        dataOutputText.text = soData.SingleName;
        nameDataStorage.SetData();
    }
}