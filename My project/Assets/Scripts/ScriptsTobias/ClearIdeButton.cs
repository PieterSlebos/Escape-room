using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClearIdeButton : MonoBehaviour
{
    [Tooltip("'Clear' button.")]
    public Button ClearButton;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI InputTextField;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = ClearButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //string startInput = LoadMissionIDE.myObject.startInput;
        string startInput = "";

        InputTextField.text = startInput;

        Debug.Log("hehehe");

    }
}