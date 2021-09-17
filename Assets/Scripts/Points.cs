using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private static int _points=0;
    public string textValue;
    public Text textElement;

    public static int points { get => _points; set => _points = value; }

    private void Update()
    {
        textElement.text = $"Points {points}";
    }
}