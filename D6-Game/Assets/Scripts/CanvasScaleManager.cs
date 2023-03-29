using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScaleManager : MonoBehaviour
{
    public Camera Camera;
    int scalingFactor;

    void Start()
    {

    }
    void Update()
    {
        scalingFactor = Camera.GetComponent<Camera>().scaledPixelWidth / 128;

        gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1) * scalingFactor;
    }
}
