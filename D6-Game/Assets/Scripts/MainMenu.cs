using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject diePrefab;
    public GameObject DisplayButtonText;
    public GameObject Colour;
    public Sprite NumbersArabic_5;
    public Sprite Numbers_5;
    int colorValue;


    private void Start()
    {
        colorValue = Colour.GetComponent<ColorPaletteController>().paletteIndex;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void ShowStats()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
    public void ChangeColor()
    {
        colorValue = (colorValue + 1) % 6;
        Colour.GetComponent<ColorPaletteController>().paletteIndex = colorValue;
    }
    

    void ChangeSprite()
    {
        diePrefab.GetComponent<DieManager>().UseArabic = !diePrefab.GetComponent<DieManager>().UseArabic;

        if (diePrefab.GetComponent<DieManager>().UseArabic)
        {
            DisplayButtonText.GetComponent<SpriteRenderer>().sprite = NumbersArabic_5;
        } else
        {
            DisplayButtonText.GetComponent<SpriteRenderer>().sprite = Numbers_5;
        }
    }
}

