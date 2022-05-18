using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestColor : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI textField;
    [SerializeField] private Text receiveTextField;

    private string textFieldText = "";

    private Text newText;



    // Start is called before the first frame update
    void Start()
    {

        newText.color = Color.red;

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



            //newText.text = textFieldText;

            receiveTextField.text = "<color=red>" + textFieldText + "</color>";

            //receiveTextField.text = "<color=red>Nananan</color>";

            //receiveTextField = newText;

        }

    }
}