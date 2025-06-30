using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerProfile", menuName = "ScriptableObjects/PlayerProfile")]
public class PlayerProfileSO : ScriptableObject
{
    public string playerName;
    public int playerLevel;
    public float playerHealth;
}
