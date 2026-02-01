using UnityEngine;
using System.Collections.Generic;

public class ModelManager : MonoBehaviour
{
    // Referensi untuk daftar model 3D
    public List<GameObject> models;

    // Fungsi untuk menampilkan model berdasarkan index
    public void ShowModel(int index)
    {
        if (index >= 0 && index < models.Count)
        {
            // Hitung kelompok (group) berdasarkan indeks
            int groupIndex = index / 3;

            // Tentukan range kelompok
            int groupStart = groupIndex * 3;
            int groupEnd = Mathf.Min(groupStart + 3, models.Count);

            // Sembunyikan semua model dalam kelompok kecuali yang dipilih
            for (int i = groupStart; i < groupEnd; i++)
            {
                models[i].SetActive(i == index);
            }
        }
        else
        {
            Debug.LogWarning("Index model tidak valid: " + index);
        }
    }
}