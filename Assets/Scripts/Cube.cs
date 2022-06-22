using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape // Inheritance
{
    private void Start()
    {
        Name = "Cube";
        Color = Color.red;
    }

    protected override void DisplayText() // Polymorphism / Abstraction
    {
        Message = $"The Red {Name} has been selected!";
        base.DisplayText();
    }
}
