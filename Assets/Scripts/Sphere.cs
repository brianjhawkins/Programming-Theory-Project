using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // Inheritance
{
    private void Start()
    {
        Name = "Sphere";
        Color = Color.green;
    }

    protected override void DisplayText() // Polymorphism / Abstraction
    {
        Message = $"A Green {Name} has been clicked!";
        base.DisplayText();
    }
}
