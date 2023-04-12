using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject DisplayButtonText;
    public GameObject Colour;
    public Sprite NumbersArabic_5;
    public Sprite Numbers_5;
    int colorValue = 0;

    private void Start()
    {
        Colour.GetComponent<ColorPaletteController>().paletteIndex = colorValue;
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
        if (DisplayButtonText.GetComponent<SpriteRenderer>().sprite == NumbersArabic_5)
        {
            DisplayButtonText.GetComponent<SpriteRenderer>().sprite = Numbers_5;
        }
        else
            DisplayButtonText.GetComponent<SpriteRenderer>().sprite = NumbersArabic_5;

    }
}

