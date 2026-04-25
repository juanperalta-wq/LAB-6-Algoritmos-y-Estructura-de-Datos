using UnityEngine;
using TMPro;

public class UIInventory : MonoBehaviour
{
    public InvetoryData data;
    public TextMeshProUGUI pistolText;
    public TextMeshProUGUI armorText;
    public TextMeshProUGUI bulletsText;

    void OnEnable() => Refresh();

    public void Refresh()
    {
        pistolText.text = $"Pistol: {data.Pistol}";
        armorText.text = $"Armor: {(data.Armor ? "Yes" : "No")}";
        bulletsText.text = $"Bullets: {data.Bullets}";
    }

    public void ModifyBullets(int value)
    {
        data.Bullets += value;
        Refresh();
    }

    public void ToggleArmor()
    {
        data.Armor = !data.Armor;
        Refresh();
    }
}
