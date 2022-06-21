using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Assets.Scripts.ScriptsTobias;
using System.IO;

public class CheckScript : MonoBehaviour
{
    [Tooltip("'Run' button.")]
    public Button RunButton;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI InputTextField;

    [Tooltip("IDE output textbox")]
    public TextMeshProUGUI OutputTextField;

    [Tooltip("Select scene after complete.")]
    public SceneNamesEnum EnumSceneDropDownSelect = new SceneNamesEnum();

    [HideInInspector]
    public bool LevelIdeSucceed;

    private bool _answerCorrect = false;

    // Get and fill MissionVariables
    private MissionVariables _missionVariables { get {
            return LoadJson();
        }
    }


    public MissionVariables LoadJson()
    {
        MissionVariables items = new MissionVariables();

        using (StreamReader r = new StreamReader("Assets/JSON/JSON_Tobias/Level_IDE/IdeMissionJSON.json"))
        {
            string json = r.ReadToEnd();
            items = JsonUtility.FromJson<MissionVariables>(json);
        }

        return items;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        LoadJson();

        Button btn = RunButton.GetComponent<Button>(); 
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        CheckAnswer();

        if (_answerCorrect)
        {
            OutputTextField.text = "Hello, world! <br><br><color=green>Correct!</color>";
            LevelSucceed();
        }
        else
        {
            OutputTextField.text = "Try again...";
        }
    }

    void CheckAnswer()
    {
        for(int i = 0; i < _missionVariables.correctAnswers.Length; i++)
        {
            if (InputTextField.text.Contains(_missionVariables.correctAnswers[i]))
            {
                _answerCorrect = true;
                break;
            }
        }
    }

    void LevelSucceed()
    {
        LevelIdeSucceed = true;
        SceneManager.LoadScene(EnumSceneDropDownSelect.ToString());
    }
}