using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    [SerializeField]
    private InputField nameInput;

    [SerializeField]
    private Text nameWarning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        if (!string.IsNullOrEmpty(nameInput.text))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            nameWarning.gameObject.SetActive(true);
        }
    }
}
