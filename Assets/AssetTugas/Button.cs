using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // Method untuk pindah ke scene AR
    public void GoToARScene()
    {
        SceneManager.LoadScene("AR"); // Pastikan nama scene "AR" sudah benar di Build Settings
    }

    // Method untuk pindah ke scene Object
    public void GoToObjectScene()
    {
        SceneManager.LoadScene("Object"); // Pastikan nama scene "Object" sudah benar di Build Settings
    }

    // Method untuk pindah ke scene Quiz
    public void GoToQuizScene()
    {
        SceneManager.LoadScene("Quiz"); // Pastikan nama scene "Quiz" sudah benar di Build Settings
    }

    // Method untuk pindah ke scene About
    public void GoToAboutScene()
    {
        SceneManager.LoadScene("About"); // Pastikan nama scene "About" sudah benar di Build Settings
    }

    // Method untuk keluar dari aplikasi
    public void ExitApplication()
    {
        Debug.Log("Aplikasi akan keluar."); // Hanya terlihat di Editor
        Application.Quit();
    }

    // Method untuk membuka link eksternal
    public void OpenBookLink()
    {
        string url = "https://drive.google.com/drive/folders/1D4zq3BXtryZv0slUQp5kHImRap1kkUn0"; // Ganti dengan URL Anda
        Application.OpenURL(url);
        Debug.Log("Membuka link: " + url); // Log untuk debugging
    }
}
