using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : MonoBehaviour
{
    private Text timeText;
    private Stopwatch timer;
    private GameMaster gameMaster;
    private long elapsedMilliseconds;
    private long gamemasterElapsedMilliseconds;

    // Start is called before the first frame update
    void Start()
    {
        timer = new Stopwatch();
        timeText = gameObject.GetComponent<Text>();
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        gamemasterElapsedMilliseconds = gameMaster.getTimeElapsed();
    }

    // Update is called once per frame
    void Update()
    {        
        elapsedMilliseconds = timer.ElapsedMilliseconds + gamemasterElapsedMilliseconds;
        timeText.text = convertMillisecToTime(elapsedMilliseconds);
    }

    public long getTimeElapsed()
    {
        return elapsedMilliseconds;
    }
    private string convertMillisecToTime(long millsec)
    {
        int seconds = (int)(millsec / 1000);
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;
        string timeString = minutes.ToString().PadLeft(2, '0') + ":" + remainingSeconds.ToString().PadLeft(2, '0');
        return timeString;
    }
    public void startTimer()
    {
        timer.Start();
    }
    public void stopTimer()
    {
        timer.Stop();
    }
    public void hideTimer()
    {
        timeText.gameObject.SetActive(false);
    }
    public void showTimer()
    {
        timeText.gameObject.SetActive(true);
    }
}
