using UnityEngine;
using UnityEngine.SceneManagement; // Untuk memuat scene

public class BackButtonScript : MonoBehaviour
{
    // Fungsi ini akan dipanggil saat tombol "Kembali" di-klik
    public void GoBackToHome()
    {
        // Pastikan scene "Home" sudah dimasukkan di Build Settings
        SceneManager.LoadScene("Home");
    }

    // Fungsi ini akan dipanggil saat tombol "Kalkulator" di-klik
    public void GoToKalkulatorScene()
    {
        // Pastikan scene "kalkulator" sudah dimasukkan di Build Settings
        SceneManager.LoadScene("kalkulator");
    }

    // Fungsi ini akan dipanggil saat tombol "Kalkulator" di-klik
    public void GoToKalARScene()
    {
        // Pastikan scene "AR" sudah dimasukkan di Build Settings
        SceneManager.LoadScene("AR");
    }
}
