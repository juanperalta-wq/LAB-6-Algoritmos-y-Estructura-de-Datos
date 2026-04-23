using UnityEngine;
using TMPro;

public class UIStats : MonoBehaviour
{
    public StatsData data;
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI strongText;

    void OnEnable() => Refresh();

    public void Refresh()
    {
        lifeText.text = $"Life: {data.Life}";
        speedText.text = $"Speed: {data.speed}";
        strongText.text = $"Strong: {data.strong}";
    }

    public void ModifyLife(int value)
    {
        data.Life += value;
        Refresh();
    }

    public void ModifySpeed(int value)
    {
        data.speed += value;
        Refresh();
    }

    public void ModifyStrong(int value)
    {
        data.strong += value;
        Refresh();
    }
}
