using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScenePortal : MonoBehaviour
{

    public bool loadRandomScene;

    public string nextScene = "";

    [HideInInspector] public List<string> ListOfScenes = new List<string>();
    [HideInInspector] public int randomSceneNumber;
    [HideInInspector] public string randomSceneName;

    private void Start()
    {
        FillSceneList();

        RandomSceneNum();

        GetRandomSceneName();

    }
    
    private void FillSceneList()
    {
        ListOfScenes.Add("Level-Moos");
        ListOfScenes.Add("Level_balls");
        ListOfScenes.Add("Scene_Level_Tobias");
    }

    private void RandomSceneNum()
    {
        int listCount = ListOfScenes.Count;
        listCount++;

        int num = Random.Range(0, listCount);
        randomSceneNumber = num;
    }

    private void GetRandomSceneName()
    {
        string sceneName;
        sceneName = ListOfScenes[randomSceneNumber].ToString();
        randomSceneName = sceneName;
    }

    private void LoadRandomScene()
    {
        SceneManager.LoadScene(randomSceneName);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(loadRandomScene)
            {
                LoadRandomScene();
                SceneManager.LoadScene(randomSceneName);
            } 
            else
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }

}
