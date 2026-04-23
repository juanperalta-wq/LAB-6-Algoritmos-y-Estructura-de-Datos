using UnityEngine;

[CreateAssetMenu(fileName = "ConfigurationData", menuName = "Scriptable Objects/ConfigurationData")]
public class ConfigurationData : ScriptableObject
{
    public bool graphicsGood;
    public int volume;
    public float sensitivity;
    public string language;
}
