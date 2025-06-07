using UnityEngine;
using UnityEngine.UI; // Для стандартного UI Text
public class PickUp : MonoBehaviour
{
    public int chestsCollected = 0;
    public Text chestCountText; // Прив’язати UI Text елемент у інспекторі
    private void Start()
    {
        UpdateChestUI();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ChestGolden"))
        {
            chestsCollected++;
            UpdateChestUI();
            Destroy(other.gameObject);
        }
    }
    void UpdateChestUI()
    {
        chestCountText.text = $"Сундуки: {chestsCollected}";
        Debug.Log("Оновлення UI: " + chestCountText.text);
    }
}