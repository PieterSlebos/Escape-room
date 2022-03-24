using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

    //Script from https://docs.unity3d.com/2018.3/Documentation/ScriptReference/UI.Button-onClick.html

    public Button PlayButton;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        PlayButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        SceneManager.LoadScene("Scene_Lobby");
    }

}