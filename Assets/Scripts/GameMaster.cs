using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    private static GameMaster instance;
    private Vector2 lastCheckpointPos;
    private Quaternion rotation;
    private long timeElapsedMillisec;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        } else
        {
            Destroy(gameObject);
        }
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
}
