using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
   

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}