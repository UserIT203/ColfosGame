using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DiePanel : MonoBehaviour
{
    public void ReturnScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        Debug.Log("Loading Main Menu...");
    }
}
