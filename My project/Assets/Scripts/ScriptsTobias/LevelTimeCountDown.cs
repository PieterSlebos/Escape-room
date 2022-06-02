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

    private DateTime _currentTime = DateTime.Now;
    private DateTime _endDateTime;
    private string _timeLeft;
    private int _minutesToSolve;
    private int _secondsToSolve;

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
        if(_timeLeft == "00:00")
        {
            TimeIsUp();
        } 
        else
        {
            CalculateDifference();
            CountDownText.text = _timeLeft;
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

        _minutesToSolve = int.Parse(minutesString);
        _secondsToSolve = int.Parse(secondsString);
    }

    void CalculateEndTime()
    {
        TimeSpan timeToSolveTS = new TimeSpan(0, _minutesToSolve, _secondsToSolve);

        _endDateTime = DateTime.Now.Add(timeToSolveTS);
    }

    void CalculateDifference()
    {
        _currentTime = DateTime.Now;

        int minutes = (_endDateTime - _currentTime).Minutes;
        int seconds = (_endDateTime - _currentTime).Seconds;

        _timeLeft = string.Format("{0:D2}:{1:D2}", minutes, seconds);
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