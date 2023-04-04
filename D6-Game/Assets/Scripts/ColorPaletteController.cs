using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPaletteController : MonoBehaviour
{
    public int paletteIndex;
    Color[,] palettes = new Color[2,16];
    public Color[] Palette0 = new Color[16];
    public Color[] Palette1 = new Color[16];

    void Awake()
    {
        for (int i = 0; i < 16; i++)
        {
            palettes[0, i] = Palette0[i];
            palettes[1, i] = Palette1[i];
        }
    }
}
