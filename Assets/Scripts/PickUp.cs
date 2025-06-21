using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;// Для стандартного UI Text
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
            if (chestsCollected >= 3)
            {
                SceneManager.LoadScene("Menu");
            }
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