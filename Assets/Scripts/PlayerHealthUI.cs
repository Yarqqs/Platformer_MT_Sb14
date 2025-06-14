using UnityEngine;
using UnityEngine.UI;  // для UI елементів

public class PlayerHealthUI : MonoBehaviour
{
    public PlayerHealth playerHealth;   // посилання на скрипт гравця з HP
    public Text hpText;                 // посилання на UI Text

    void Update()
    {
        if (playerHealth != null && hpText != null)
        {
            hpText.text = "HP: " + playerHealth.health.ToString();
        }
    }
}
