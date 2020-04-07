using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public partial class DataStorage : ScriptableObject
{
    public ScriptableObject data;

    public void SetData()
    {
        if (data == null) return;
        PlayerPrefs.SetString(data.name, JsonUtility.ToJson(data));
    }

    public void GetData()
    {
        if (data == null) return;
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(data.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(data.name), data);
    }
}