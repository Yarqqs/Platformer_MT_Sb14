using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;

    // Метод для нанесення урону
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Гравець отримав урон! Залишилось HP: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    // Метод смерті гравця
    void Die()
    {
        Debug.Log("Гравець загинув!");
        RestartLevel();
    }

    // Метод перезапуску рівня
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
