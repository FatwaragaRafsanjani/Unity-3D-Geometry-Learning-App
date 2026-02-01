using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimasSegitiga : MonoBehaviour
{
    public Text textFieldTinggiAlas;   // Input untuk tinggi alas segitiga
    public Text textFieldAlas;         // Input untuk alas segitiga
    public Text textFieldTinggiLimas;  // Input untuk tinggi limas
    public Text textFieldLuasPermukaan; // Input untuk luas permukaan
    public Text hasil;                 // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume limas
    public void hitungVolume()
    {
        // Mengambil nilai alas, tinggi alas, dan tinggi limas dari input
        float tinggiAlas = float.Parse(textFieldTinggiAlas.text);
        float alas = float.Parse(textFieldAlas.text);
        float tinggiLimas = float.Parse(textFieldTinggiLimas.text);

        // Menghitung luas alas segitiga (1/2 * alas * tinggi alas)
        float luasAlas = 0.5f * alas * tinggiAlas;

        // Menghitung volume limas segitiga (1/3 * luas alas * tinggi limas)
        float volume = (1f / 3f) * luasAlas * tinggiLimas;

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan limas
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai luas permukaan dari input
        float luasPermukaan = float.Parse(textFieldLuasPermukaan.text);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}
