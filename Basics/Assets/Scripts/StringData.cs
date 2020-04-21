using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;
    public string SingleName { get; set; }
}