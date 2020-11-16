using UnityEngine;

public class LevelController : MonoBehaviour
{
    public bool playLevelCountdown;
    float countdownTime;
    float decreaseCountDownTime;
    float spacecraftSpeedMultiplyer = 3.0f;
    SpacecraftControls spacecraftControls;
    SpacecraftMovement spacecraftMovement;
    Canvas countdown;
    Animator countdownAnimator;
    // Start is called before the first frame update
    void Start()
    {
        countdown = GameObject.FindObjectOfType<Canvas>();
        countdownAnimator = countdown.GetComponent<Animator>();
        spacecraftControls = FindObjectOfType<SpacecraftControls>();
        spacecraftMovement = FindObjectOfType<SpacecraftMovement>();
        countdownTime = 4.0f;
        decreaseCountDownTime = countdownTime;
        if(playLevelCountdown)
        {
            beginCountdown();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playLevelCountdown)
        {
            if(decreaseCountDownTime > 0)
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
    }
}
