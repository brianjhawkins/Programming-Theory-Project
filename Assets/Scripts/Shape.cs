using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private string m_Name;
    private Color m_Color;
    private Text m_Text;

    private void Awake()
    {
        m_Text = FindObjectOfType<Text>();
    }

    public Text Text
    {
        get
        {
            return m_Text;
        }

        set
        {
            m_Text = value;
        }
    }

    public string Name
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

    public Color Color
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
        m_Text.text = "You clicked on a generic shape!";
    }

    public void OnMouseDown()
    {
        DisplayText();
    }
}
