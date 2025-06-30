using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ProfileDisplay : MonoBehaviour
{
    public PlayerProfileSO playerProfile;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI healthText;

    void Start()
    {
        if (playerProfile != null)
        {
            nameText.text = $"Name: {playerProfile.playerName}";
            levelText.text = $"Level: {playerProfile.playerLevel}";
            healthText.text = $"Health: {playerProfile.playerHealth}";
        }
    }
}
