using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;




public class LevelTimeCountDown : MonoBehaviour
{
    [Tooltip("Minutes : Seconds | no spaces, if 0 seconds please write ##:00")]
    public string TimeToSolve;

    [Tooltip("Select scene after time is up")]
    public SceneNamesEnum enumSceneDropDownSelect = new SceneNamesEnum();

    public Text CountDownText;

    public static bool LevelTimeIsUp = false;

    private DateTime CurrenTime = DateTime.Now;
    private DateTime EndDateTime;
    private string TimeLeft;

    private int MinutesToSolve;
    private int SecondsToSolve;

    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        ConvertTimeToInt();
        CalculateEndTime();
        CalculateDifference();

        img.color = new Color(1, 1, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(TimeLeft == "00:00")
        {
            // Something to do when done

            TimeIsUp();

        } 
        else
        {
            CalculateDifference();
            CountDownText.text = TimeLeft;
        }
    }

    void ConvertTimeToInt()
    {
        string wholeStringTime = TimeToSolve;
        string minutesString;
        string secondsString;

        string[] spiltTime = wholeStringTime.Split(':');

        minutesString = spiltTime[0];
        secondsString = spiltTime[1];

        MinutesToSolve = int.Parse(minutesString);
        SecondsToSolve = int.Parse(secondsString);
    }

    void CalculateEndTime()
    {
        TimeSpan timeToSolveTS = new TimeSpan(0, MinutesToSolve, SecondsToSolve);

        EndDateTime = DateTime.Now.Add(timeToSolveTS);
    }

    void CalculateDifference()
    {
        CurrenTime = DateTime.Now;

        int minutes = (EndDateTime - CurrenTime).Minutes;
        int seconds = (EndDateTime - CurrenTime).Seconds;

        TimeLeft = string.Format("{0:D2}:{1:D2}", minutes, seconds);
    }

    void TimeIsUp()
    {
        LevelTimeIsUp = true;
        StartCoroutine(FadeImageToNextScene()); // Fades in image + waits + next scene

    }

    IEnumerator FadeImageToNextScene() // https://forum.unity.com/threads/simple-ui-animation-fade-in-fade-out-c.439825/
    {
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            yield return null;
        }

        yield return new WaitForSecondsRealtime(2);

        SceneManager.LoadScene(enumSceneDropDownSelect.ToString());
    }
}
