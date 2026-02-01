using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kerucut : MonoBehaviour
{
    public Text textFieldRadius;      // Input untuk radius kerucut
    public Text textFieldTinggi;      // Input untuk tinggi kerucut
    public Text textFieldGarisPelukis; // Input untuk garis pelukis kerucut
    public Text hasil;                // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume kerucut
    public void hitungVolume()
    {
        // Mengambil nilai radius dan tinggi dari input
        float radius = float.Parse(textFieldRadius.text);
        float tinggi = float.Parse(textFieldTinggi.text);

        // Menghitung volume kerucut (1/3 * π * r² * t)
        float volume = (1f / 3f) * Mathf.PI * Mathf.Pow(radius, 2) * tinggi;

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan kerucut
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai radius dan garis pelukis dari input
        float radius = float.Parse(textFieldRadius.text);
        float garisPelukis = float.Parse(textFieldGarisPelukis.text);

        // Menghitung luas permukaan kerucut (π * r * (r + s))
        float luasPermukaan = Mathf.PI * radius * (radius + garisPelukis);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}
