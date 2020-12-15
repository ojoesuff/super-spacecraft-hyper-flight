using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    SpacecraftController spacecraftController;
    bool countdownPlaying;
    bool gamePaused;
    bool spacecraftDead;
    GameObject pauseMenu;
    LevelTime levelTime;

    // Start is called before the first frame update
    void Start()
    {
        spacecraftController = FindObjectOfType<SpacecraftController>();        
        gamePaused = false;
        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
        levelTime = FindObjectOfType<LevelTime>();
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        countdownPlaying = FindObjectOfType<LevelController>().countdownPlaying;
        spacecraftDead = FindObjectOfType<SpacecraftDeath>().spacecraftDead;

        if (Input.GetKeyDown(KeyCode.Escape) && !countdownPlaying && !spacecraftDead)
        {
            if(gamePaused)
            {
                unpauseGame();
                gamePaused = false;
            } else
            {
                pauseGame();
                gamePaused = true;
            }
        }        
    }

    void pauseGame()
    {
        spacecraftController.DisableSpacecraft();
        pauseMenu.SetActive(true);
        levelTime.stopTimer();
        levelTime.hideTimer();
    }
    void unpauseGame()
    {
        spacecraftController.enableSpacecraft();
        pauseMenu.SetActive(false);
        levelTime.startTimer();
        levelTime.showTimer();
    }

    // last checkpoint
    // restart level
    // quit game
}
