using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts.ScriptsTobias;
using System.IO;

public class LoadMissionIDE : MonoBehaviour
{
    [Tooltip("Mission title textbox")]
    public TextMeshProUGUI MissionTitleTB;

    [Tooltip("Mission description textbox")]
    public TextMeshProUGUI MissionDescrTB;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI IdeInput;

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
        FillVariables();
    }

    void FillVariables()
    {
        BuildDesc();
        MissionTitleTB.text = _missionVariables.missionTitle;
        IdeInput.text = _missionVariables.startInput;
    }

    void BuildDesc() // Build description textbox text
    {
        string tempDescr;

        tempDescr = "<color=\"" + _missionVariables.missionLanguageColor + "\">" + _missionVariables.missionLanguageName + "</color>";
        tempDescr += "<br><br>";
        tempDescr += _missionVariables.missionDescription;

        MissionDescrTB.text = tempDescr;
    }
}