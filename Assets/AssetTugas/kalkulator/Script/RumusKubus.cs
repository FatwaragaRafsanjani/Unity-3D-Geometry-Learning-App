using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kubus : MonoBehaviour
{
    public Text textFieldSisi;  // Input untuk sisi kubus
    public Text hasil;          // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume kubus
    public void hitungVolume()
    {
        // Mengambil nilai sisi dari input
        float sisi = float.Parse(textFieldSisi.text);

        // Menghitung volume kubus
        float volume = Mathf.Pow(sisi, 3);

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan kubus
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai sisi dari input
        float sisi = float.Parse(textFieldSisi.text);

        // Menghitung luas permukaan kubus
        float luasPermukaan = 6 * Mathf.Pow(sisi, 2);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}