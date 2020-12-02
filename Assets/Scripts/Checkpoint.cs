using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gameMaster;
    private LevelTime levelTime;

    private void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        levelTime = FindObjectOfType<LevelTime>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameMaster.setLastCheckpointPos(transform.position);
            gameMaster.setSpacecraftRotation(transform.rotation);
            gameMaster.setTimeElapsed(levelTime.getTimeElapsed());
        }
    }
}
