using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour
{
    public Text textFieldRadius;  // Input untuk radius bola
    public Text hasil;            // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume bola
    public void hitungVolume()
    {
        // Mengambil nilai radius dari input
        float radius = float.Parse(textFieldRadius.text);

        // Menghitung volume bola (4/3 * π * r³)
        float volume = (4f / 3f) * Mathf.PI * Mathf.Pow(radius, 3);

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan bola
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai radius dari input
        float radius = float.Parse(textFieldRadius.text);

        // Menghitung luas permukaan bola (4 * π * r²)
        float luasPermukaan = 4 * Mathf.PI * Mathf.Pow(radius, 2);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}
