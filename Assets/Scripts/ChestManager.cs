// using UnityEngine;
// using TMPro;

// public class ChestManager : MonoBehaviour
// {
//     public TextMeshProUGUI chestCounterText; // посилання на TextMeshProUGUI на Canvas
//     private int chestCount = 0;

//     private void Start()
//     {
//         UpdateChestText();
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Chest"))
//         {
//             chestCount++;
//             UpdateChestText();
//             Destroy(other.gameObject);
//         }
//     }

//     private void UpdateChestText()
//     {
//         if (chestCounterText != null)
//         {
//             chestCounterText.text = "Сундуки: " + chestCount;
//         }
//         else
//         {
//             Debug.LogWarning("ChestCounterText не призначений у ChestManager!");
//         }
//     }
// }
