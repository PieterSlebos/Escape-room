using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckScript : MonoBehaviour
{

    public Button runButton;
    public TextMeshProUGUI inputTextField;
    public TextMeshProUGUI outputTextField;

    private string answerOfMission = "print('Hello, world!')";

    // Start is called before the first frame update
    void Start()
    {
        Button btn = runButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        if (inputTextField.text.Contains(answerOfMission))
        {
            outputTextField.text = "Hello, world!";
        }
        else
        {
            outputTextField.text = "Try again...";
        }

    }
}
