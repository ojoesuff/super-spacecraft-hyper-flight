using UnityEngine;

public class LevelController : MonoBehaviour
{
    private bool playLevelCountdown;
    float countdownTime;
    float decreaseCountDownTime;
    float spacecraftSpeedMultiplyer = 3.0f;
    SpacecraftControls spacecraftControls;
    SpacecraftMovement spacecraftMovement;
    Canvas countdown;
    Animator countdownAnimator;
    GameMaster gameMaster;
    LevelTime levelTime;
    public bool countdownPlaying;
    // Start is called before the first frame update
    void Start()
    {
        countdown = GameObject.Find("CountdownCanvas").GetComponent<Canvas>();
        countdownAnimator = countdown.GetComponent<Animator>();
        spacecraftControls = FindObjectOfType<SpacecraftControls>();
        spacecraftMovement = FindObjectOfType<SpacecraftMovement>();
        levelTime = FindObjectOfType<LevelTime>();
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        playLevelCountdown = gameMaster.getPlayCountdown();
        countdownTime = 4.0f;
        decreaseCountDownTime = countdownTime;
        if(playLevelCountdown)
        {
            beginCountdown();
        } else
        {
            levelTime.startTimer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        countdownPlaying = decreaseCountDownTime > 0;
        if(playLevelCountdown)
        {
            if(countdownPlaying)
            {
                decreaseCountDownTime -= Time.deltaTime;
            } else
            {
                endCountdown();
            }

        }
    }

    void beginCountdown()
    {
        //disable controls
        spacecraftControls.enabled = false;
        spacecraftMovement.decreaseCraftSpeed(spacecraftSpeedMultiplyer);
        //play animation
        countdownAnimator.SetTrigger("startCountdown");
    }

    void endCountdown()
    {
        //enable controls
        playLevelCountdown = false;
        spacecraftControls.enabled = true;
        spacecraftMovement.increaseCraftSpeed(spacecraftSpeedMultiplyer);
        gameMaster.disableCountdown();
        levelTime.startTimer();
    }
}
