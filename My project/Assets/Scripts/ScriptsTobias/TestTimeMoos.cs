using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TestTimeMoos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AfterCollission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void AfterCollission()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10); 

        while(currentTime < endTime)
        {
            Debug.Log("Nog niet man");
        }
    }
}
