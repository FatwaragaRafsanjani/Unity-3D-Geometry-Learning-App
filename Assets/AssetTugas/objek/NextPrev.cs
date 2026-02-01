using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Image displayImage; // Referensi ke Image UI
    public Sprite[] images;   // Array gambar yang akan ditampilkan
    private int currentIndex = 0; // Indeks gambar saat ini

    void Start()
    {
        if (images.Length > 0)
        {
            displayImage.sprite = images[currentIndex]; // Set gambar awal
        }
    }

    public void NextImage()
    {
        if (images.Length > 0)
        {
            currentIndex = (currentIndex + 1) % images.Length; // Berputar ke awal jika mencapai akhir
            displayImage.sprite = images[currentIndex];
        }
    }

    public void PreviousImage()
    {
        if (images.Length > 0)
        {
            currentIndex = (currentIndex - 1 + images.Length) % images.Length; // Berputar ke akhir jika kurang dari awal
            displayImage.sprite = images[currentIndex];
        }
    }
}
