using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadMissionIDE : MonoBehaviour
{
    
    [Header("Files")]

    [Tooltip("File that contains the JSON file with all the missions.")]
    public TextAsset textJSON;

    [Header("Field inputs")]

    [Tooltip("Mission title textbox")]
    public TextMeshProUGUI missionTitleTB;

    [Tooltip("Mission description textbox")]
    public TextMeshProUGUI missionDescrTB;

    [Tooltip("IDE input textbox")]
    public TextMeshProUGUI ideInput;

    public class MissionVariables
    {
        public int id;
        public string missionTitle;
        public string missionDescription;
        public string missionLanguageName;
        public string missionLanguageColor;
        public string startInput;
    }

    MissionVariables myObject = new MissionVariables();

    // Start is called before the first frame update
    void Start()
    {
        myObject = JsonUtility.FromJson<MissionVariables>(textJSON.text);

        FillVariables();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FillVariables()
    {
        missionTitleTB.text = myObject.missionTitle;
        BuildDesc();
        ideInput.text = myObject.startInput;
        //missionDescrTB.text = myObject.missionDescription;
    }

    void BuildDesc()
    {
        string TempDescr;

        TempDescr = "<color=\"" + myObject.missionLanguageColor + "\">" + myObject.missionLanguageName + "</color>";
        TempDescr += "<br><br>";
        TempDescr += myObject.missionDescription;

        missionDescrTB.text = TempDescr;
    }
}
