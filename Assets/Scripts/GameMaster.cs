using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    private static GameMaster instance;
    private Vector2 lastCheckpointPos;
    private Quaternion rotation;
    private long timeElapsedMillisec;
    private bool playCountdown;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        playCountdown = true;
    }

    public void setLastCheckpointPos(Vector2 pos)
    {
        lastCheckpointPos = pos;
    }

    public Vector2 getLastCheckpointPos()
    {
        return lastCheckpointPos;
    }

    public void setSpacecraftRotation(Quaternion checkpointRotation)
    {
        rotation = checkpointRotation;
    }
    public Quaternion getSpacecraftRotation()
    {
        return rotation;
    }
    public void setTimeElapsed(long timeMillisec)
    {
        timeElapsedMillisec = timeMillisec;
    }
    public long getTimeElapsed()
    {
        return timeElapsedMillisec;
    }
    public void enableCountdown()
    {
        playCountdown = true;
    }
    public void disableCountdown()
    {
        playCountdown = false;
    }
    public bool getPlayCountdown()
    {
        return playCountdown;
    }
    public void resetParameters()
    {
        lastCheckpointPos = Vector2.zero;
        rotation = Quaternion.identity;
        timeElapsedMillisec = 0;
        playCountdown = true;
    }

}