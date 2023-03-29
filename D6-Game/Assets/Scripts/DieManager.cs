using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieManager : MonoBehaviour
{
    public Color[] dieColors;
    public Color[] numberColors;

    public bool UseArabic = false;

    public Sprite[] numberSprites;

    public GameObject Square;
    public GameObject Number;

    public int colorIndex;
    public int numberIndex;

    

    void Start()
    {
        colorIndex = Random.Range(0, dieColors.Length);
        numberIndex = Random.Range(0, 6);

        if (UseArabic) {
            numberIndex += 6;
        }

        Square.GetComponent<SpriteRenderer>().color = dieColors[colorIndex];
        Number.GetComponent<SpriteRenderer>().color = numberColors[colorIndex];
        Number.GetComponent<SpriteRenderer>().sprite = numberSprites[numberIndex];
    }

}
