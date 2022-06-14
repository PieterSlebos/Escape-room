using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckScript : MonoBehaviour
{

    [Tooltip("'Run' button.")]
    public Button runButton;

    [Tooltip("File that contains the JSON file with all the missions.")]
    public TextAsset textJSON;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI inputTextField;

    [Tooltip("IDE output textbox")]
    public TextMeshProUGUI outputTextField;

    public class CorrectAnswers
    {
        public string correctAnswers;
    }

    CorrectAnswers myObject = new CorrectAnswers();

    private string answerOfMission = "print('Hello, world!')";

    public bool LevelIdeSucceed;

    // Start is called before the first frame update
    void Start()
    {

        myObject = JsonUtility.FromJson<CorrectAnswers>(textJSON.text);

        Debug.Log(myObject.correctAnswers.ToString());
        outputTextField.text = myObject.correctAnswers.ToString();

        Button btn = runButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (inputTextField.text.Contains(answerOfMission))
        {
            outputTextField.text = "Hello, world! <br><br><color=green>Correct!</color>";
            LevelSucceed();
        }
        else
        {
            outputTextField.text = "Try again...";
        }
    }

    void LevelSucceed()
    {
        LevelIdeSucceed = true;
    }
}
