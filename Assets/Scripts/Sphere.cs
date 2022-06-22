using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        Name = "Sphere";
        Color = Color.green;
    }

    protected override void DisplayText()
    {
        Text.text = $"A Green {Name} has been clicked!";
    }
}
