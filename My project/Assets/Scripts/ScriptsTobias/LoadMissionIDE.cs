using UnityEngine;
using TMPro;
using Assets.Scripts.ScriptsTobias;
using System.IO;

public class LoadMissionIDE : MonoBehaviour
{
    [Tooltip("Mission title textbox")]
    public TextMeshProUGUI MissionTitleTB;

    [Tooltip("Mission description textbox")]
    public TextMeshProUGUI MissionDescriptionTB;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI IdeInput;

    // Get and fill MissionVariables
    private MissionVariables _missionVariables
    {
        get
        {
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
        BuildDescription();
        MissionTitleTB.text = _missionVariables.missionTitle;
        IdeInput.text = _missionVariables.startInput;
    }

    void BuildDescription() // Build description textbox text
    {
        string tempDescription;

        tempDescription = "<color=\"" + _missionVariables.missionLanguageColor + "\">" + _missionVariables.missionLanguageName + "</color>";
        tempDescription += "<br><br>";
        tempDescription += _missionVariables.missionDescription;
        
        MissionDescriptionTB.text = tempDescription;
    }
}