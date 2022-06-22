using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        Name = "Cylinder";
        Color = Color.blue;
    }

    protected override void DisplayText()
    {
        Text.text = $"You clicked on a Blue {Name}!";
    }
}
