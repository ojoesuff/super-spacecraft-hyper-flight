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

    // Start is called before the first frame update
    void Start()
    {
        spacecraftController = FindObjectOfType<SpacecraftController>();        
        gamePaused = false;
        pauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
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
    }
    void unpauseGame()
    {
        spacecraftController.enableSpacecraft();
    }
}
