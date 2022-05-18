using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestColor : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textField;

    private string textFieldText = "";



    // Start is called before the first frame update
    void Start()
    {

        // textField.text = "Enter Text Here...";

        textFieldText = textField.text;

    }

    // Update is called once per frame
    void Update()
    {

        if (textField.text != textFieldText)
        {
            Debug.Log(textField.text);
            textFieldText = textField.text;
        }

    }
}