using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private string m_Name;
    private Color m_Color;

    public string Name
    {
        get;
        set;
    }

    public Color Color
    {
        get;
        set;
    }

    public virtual void DisplayText()
    {
        Debug.Log("Clicked on a generic shape!");
    }
}
