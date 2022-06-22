using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape
{
    private void Start()
    {
        Name = "Cube";
        Color = Color.red;
    }

    protected override void DisplayText()
    {
        Text.text = $"The Red {Name} has been selected!";
    }
}
