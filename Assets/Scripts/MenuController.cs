using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Метод для переходу на перший рівень
    public void StartGame()
    {
        SceneManager.LoadScene(1); // Завантажуємо сцену з індексом 1 (1-й рівень)
    }

    // Метод для виходу з гри
    public void QuitGame()
    {
        Debug.Log("Гра закрита!");
        Application.Quit();
    }
}
