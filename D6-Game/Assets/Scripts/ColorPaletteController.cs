using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPaletteController : MonoBehaviour
{
    public int paletteIndex = 0;
    Color[,] palettes = new Color[6,16];
    public Color[] Palette0 = new Color[16];
    public Color[] Palette1 = new Color[16];
    public Color[] Palette2 = new Color[16];
    public Color[] Palette3 = new Color[16];
    public Color[] Palette4 = new Color[16];
    public Color[] Palette5 = new Color[16];
    

    public Material[] colorMaterials = new Material[16];

    void Awake()
    {
        for (int i = 0; i < 16; i++)
        {
            palettes[0, i] = Palette0[i];
            palettes[1, i] = Palette1[i];
            palettes[2, i] = Palette2[i];
            palettes[3, i] = Palette3[i];
            palettes[4, i] = Palette4[i];
            palettes[5, i] = Palette5[i];
        }

        UpdateColorMaterials();
    }

    void UpdateColorMaterials()
    {
        for (int i = 0; i < 16; i++)
        {
            colorMaterials[i].color = palettes[paletteIndex, i];
        }
    }

    public Color GetColor(int index)
    {
        return palettes[paletteIndex, index];
    }


}
