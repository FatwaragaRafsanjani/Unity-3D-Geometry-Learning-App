using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabung : MonoBehaviour
{
    public Text textFieldRadius;  // Input untuk radius tabung
    public Text textFieldTinggi; // Input untuk tinggi tabung
    public Text hasil;            // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume tabung
    public void hitungVolume()
    {
        // Mengambil nilai radius dan tinggi dari input
        float radius = float.Parse(textFieldRadius.text);
        float tinggi = float.Parse(textFieldTinggi.text);

        // Menghitung volume tabung (π * r² * t)
        float volume = Mathf.PI * Mathf.Pow(radius, 2) * tinggi;

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan tabung
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai radius dan tinggi dari input
        float radius = float.Parse(textFieldRadius.text);
        float tinggi = float.Parse(textFieldTinggi.text);

        // Menghitung luas permukaan tabung (2 * π * r * (r + t))
        float luasPermukaan = 2 * Mathf.PI * radius * (radius + tinggi);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}
