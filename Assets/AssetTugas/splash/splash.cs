using System.Collections; // Dibutuhkan untuk IEnumerator
using UnityEngine;
using UnityEngine.SceneManagement; // Dibutuhkan untuk SceneManager

public class SplashScreen : MonoBehaviour
{
    public float delay = 3f; // Durasi splash screen dalam detik
    public string nextSceneName = "MainMenu"; // Nama scene berikutnya

    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextSceneName);
    }
}
