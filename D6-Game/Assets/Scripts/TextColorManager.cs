using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextColorManager : MonoBehaviour
{
    public Material color;
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().color = color.color;
    }
}
