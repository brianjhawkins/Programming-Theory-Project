using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private string m_Name;
    private Color m_Color;
    private string m_Message;

    private void Start()
    {
        Message = "You clicked on a generic shape!";
    }

    public string Message // Encapsulation
    {
        get
        {
            return m_Message;
        }

        set
        {
            m_Message = value;
        }
    }

    public string Name // Encapsulation
    {
        get
        {
            return m_Name;
        }

        set
        {
            m_Name = value;
        }
    }

    public Color Color // Encapsulation
    {
        get
        {
            return m_Color;
        }

        set
        {
            m_Color = value;
        }
    }

    protected virtual void DisplayText()
    {
        Text m_Text = FindObjectOfType<Text>();

        m_Text.text = Message;
    }

    public void OnMouseDown()
    {
        DisplayText();
    }
}
