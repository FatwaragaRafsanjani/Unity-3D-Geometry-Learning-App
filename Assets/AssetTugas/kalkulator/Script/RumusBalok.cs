using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balok : MonoBehaviour
{
    public Text textFieldPanjang; // Input untuk panjang balok
    public Text textFieldLebar;   // Input untuk lebar balok
    public Text textFieldTinggi;  // Input untuk tinggi balok
    public Text hasil;            // Output untuk menampilkan hasil

    // Fungsi untuk menghitung volume balok
    public void hitungVolume()
    {
        // Mengambil nilai panjang, lebar, dan tinggi dari input
        float panjang = float.Parse(textFieldPanjang.text);
        float lebar = float.Parse(textFieldLebar.text);
        float tinggi = float.Parse(textFieldTinggi.text);

        // Menghitung volume balok (panjang * lebar * tinggi)
        float volume = panjang * lebar * tinggi;

        // Menampilkan hasil volume di UI
        hasil.text = "Volume: " + volume.ToString("F2");
    }

    // Fungsi untuk menghitung luas permukaan balok
    public void hitungLuasPermukaan()
    {
        // Mengambil nilai panjang, lebar, dan tinggi dari input
        float panjang = float.Parse(textFieldPanjang.text);
        float lebar = float.Parse(textFieldLebar.text);
        float tinggi = float.Parse(textFieldTinggi.text);

        // Menghitung luas permukaan balok (2 * (pl + pt + lt))
        float luasPermukaan = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi);

        // Menampilkan hasil luas permukaan di UI
        hasil.text = "Luas Permukaan: " + luasPermukaan.ToString("F2");
    }
}
