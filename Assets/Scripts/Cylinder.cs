using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // Inheritance
{
    private void Start()
    {
        Name = "Cylinder";
        Color = Color.blue;
    }

    protected override void DisplayText() // Polymorphism / Abstraction
    {
        Message = $"You clicked on a Blue {Name}!";
        base.DisplayText();
    }
}
