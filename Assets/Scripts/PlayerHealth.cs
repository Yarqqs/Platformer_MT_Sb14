// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class PlayerHealth : MonoBehaviour
// {
//     public int health = 3;

//     // Метод для нанесення урону
//     public void TakeDamage(int damage)
//     {
//         health -= damage;
//         Debug.Log("Гравець отримав урон! Залишилось HP: " + health);

//         if (health <= 0)
//         {
//             Die();
//         }
//     }

//     // Метод смерті гравця
//     void Die()
//     {
//         Debug.Log("Гравець загинув!");
//         RestartLevel();
//     }

//     // Метод перезапуску рівня
//     void RestartLevel()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//     }
// }
using UnityEngine;
using TMPro;
using System.Collections;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int maxHealth = 100;
    private int currentHealth;

    [Header("Invulnerability Settings")]
    public float invulnerabilityTime = 2f; // час неуразливості після отримання шкоди
    private bool isInvulnerable = false;

    [Header("UI")]
    public TextMeshProUGUI healthText;

    [Header("Visual Effect (optional)")]
    public Renderer playerRenderer;
    public Color damageColor = Color.red;
    public Color normalColor = Color.white;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isInvulnerable)
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        UpdateHealthText();
        Debug.Log("Отримано шкоди! HP: " + currentHealth);

        StartCoroutine(InvulnerabilityCoroutine());
    }

    IEnumerator InvulnerabilityCoroutine()
    {
        isInvulnerable = true;

        // Блимання або зміна кольору гравця на час неуразливості
        if (playerRenderer != null)
        {
            float blinkInterval = 0.2f;
            float elapsedTime = 0f;

            while (elapsedTime < invulnerabilityTime)
            {
                playerRenderer.material.color = damageColor;
                yield return new WaitForSeconds(blinkInterval / 2);
                playerRenderer.material.color = normalColor;
                yield return new WaitForSeconds(blinkInterval / 2);

                elapsedTime += blinkInterval;
            }
        }
        else
        {
            // Якщо немає рендера, просто чекати час неуразливості
            yield return new WaitForSeconds(invulnerabilityTime);
        }

        isInvulnerable = false;
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "HP: " + currentHealth;
        }
    }
}
