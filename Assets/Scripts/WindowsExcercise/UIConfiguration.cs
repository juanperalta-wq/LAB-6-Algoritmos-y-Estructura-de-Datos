using UnityEngine;
using TMPro;

public class UIConfiguration : MonoBehaviour
{
    public ConfigurationData data;
    public TextMeshProUGUI graphicsText;
    public TextMeshProUGUI volumeText;
    public TextMeshProUGUI sensitivityText;
    public TextMeshProUGUI languageText;

    void OnEnable() => Refresh();

    public void Refresh()
    {
        graphicsText.text = $"Graphics: {(data.graphicsGood ? "High" : "Low")}";
        volumeText.text = $"Volume: {data.volume}";
        sensitivityText.text = $"Sensitivity: {data.sensitivity:F1}";
        languageText.text = $"Language: {data.language}";
    }

    public void ToggleGraphics()
    {
        data.graphicsGood = !data.graphicsGood;
        Refresh();
    }

    public void ModifyVolume(int value)
    {
        data.volume += value;
        Refresh();
    }

    public void ModifySensitivity(float value)
    {
        data.sensitivity += value;
        Refresh();
    }
}
