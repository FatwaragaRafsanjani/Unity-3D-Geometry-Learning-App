using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class QuizManager : MonoBehaviour
{
    [System.Serializable]
    public class Soal
    {
        public string pertanyaan;
        public string[] pilihan = new string[4];
        public int jawabanBenar;
    }

    public Soal[] semuaSoal;
    private List<Soal> soalDipilih;
    public int jumlahSoalTampil = 5;

    public Text teksSoal;
    public Button[] tombolPilihan;
    public GameObject tombolPlayAgain; // GameObject for the Play Again button
    public Text teksHasil; // Text to display the result (correct answers count)
    public Text teksNilai; // Text to display the score as a percentage
    public GameObject bg1; // Current background GameObject
    public GameObject bg2; // New background GameObject to switch to

    private int indeksSoalSaatIni = 0;
    private int skor = 0;
    private bool isAnswered = false; // Flag to prevent multiple answers

    void Start()
    {
        tombolPlayAgain.SetActive(false); // Hide Play Again button at the start
        teksHasil.gameObject.SetActive(false); // Hide result text at the start
        teksNilai.gameObject.SetActive(false); // Hide score text at the start
        bg2.SetActive(false); // Ensure the second background is initially hidden
        PilihDanAcakSoal();
        TampilkanSoal();
    }

    void PilihDanAcakSoal()
    {
        List<Soal> daftarSemuaSoal = new List<Soal>(semuaSoal);

        for (int i = daftarSemuaSoal.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            Soal temp = daftarSemuaSoal[i];
            daftarSemuaSoal[i] = daftarSemuaSoal[randomIndex];
            daftarSemuaSoal[randomIndex] = temp;
        }

        soalDipilih = daftarSemuaSoal.GetRange(0, Mathf.Min(jumlahSoalTampil, daftarSemuaSoal.Count));
    }

    void TampilkanSoal()
    {
        isAnswered = false; // Reset flag for the new question

        if (indeksSoalSaatIni < soalDipilih.Count)
        {
            Soal soal = soalDipilih[indeksSoalSaatIni];
            teksSoal.text = soal.pertanyaan;

            for (int i = 0; i < tombolPilihan.Length; i++)
            {
                tombolPilihan[i].GetComponentInChildren<Text>().text = soal.pilihan[i];
                tombolPilihan[i].onClick.RemoveAllListeners();
                tombolPilihan[i].GetComponent<Image>().color = Color.white; // Reset warna tombol
                int pilihanIndex = i;
                tombolPilihan[i].onClick.AddListener(() => StartCoroutine(CekJawaban(pilihanIndex)));
            }
        }
        else
        {
            AkhiriKuis();
        }
    }

    IEnumerator CekJawaban(int pilihanIndex)
    {
        if (isAnswered) yield break; // Prevent further input

        isAnswered = true; // Set flag to true as the answer is being processed

        Soal soalSaatIni = soalDipilih[indeksSoalSaatIni];

        if (pilihanIndex == soalSaatIni.jawabanBenar)
        {
            skor++;
            tombolPilihan[pilihanIndex].GetComponent<Image>().color = Color.green;
        }
        else
        {
            tombolPilihan[pilihanIndex].GetComponent<Image>().color = Color.red;
            tombolPilihan[soalSaatIni.jawabanBenar].GetComponent<Image>().color = Color.green;
        }

        // Wait for 2 seconds before moving to the next question
        yield return new WaitForSeconds(2f);

        indeksSoalSaatIni++;
        TampilkanSoal();
    }

    void AkhiriKuis()
    {
        teksSoal.gameObject.SetActive(false); // Hide the question text
        teksHasil.gameObject.SetActive(true); // Show the result text
        teksNilai.gameObject.SetActive(true); // Show the score text
        teksHasil.text = $"{skor}/{soalDipilih.Count}";

        int nilai = (int)(((float)skor / soalDipilih.Count) * 100);
        teksNilai.text = $"{nilai}";

        foreach (var tombol in tombolPilihan)
        {
            tombol.gameObject.SetActive(false); // Disable answer buttons at the end
        }

        tombolPlayAgain.SetActive(true); // Show Play Again button at the end

        // Hide current background and show new background
        bg1.SetActive(false);
        bg2.SetActive(true);
    }

    // This method is called when the Play Again button is clicked
    public void PlayAgain()
    {
        skor = 0; // Reset score
        indeksSoalSaatIni = 0; // Reset the question index
        PilihDanAcakSoal(); // Re-select and shuffle questions
        TampilkanSoal(); // Show the first question
        bg1.SetActive(true); // Ensure the first background is shown
        bg2.SetActive(false); // Hide the second background
        teksSoal.gameObject.SetActive(true); // Ensure the question text is visible
        tombolPlayAgain.SetActive(false); // Hide the Play Again button during the quiz
        
        // Re-enable all the answer buttons
        foreach (var tombol in tombolPilihan)
        {
            tombol.gameObject.SetActive(true); // Make sure the buttons are active
            tombol.GetComponent<Image>().color = Color.white; // Reset button colors
        }
    }
}
