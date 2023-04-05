using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorManager : MonoBehaviour
{
    public Material color;
    void Start()
    {
        gameObject.GetComponent<Camera>().backgroundColor = color.color;
    }
}
