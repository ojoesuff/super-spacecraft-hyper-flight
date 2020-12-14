using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SpacecraftController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    SpacecraftControls spacecraftControls;
    GameObject trail;
    SpacecraftMovement spacecraftMovement;
    SpacecraftDeath spacecraftDeath;
    public float winSpeed;
    private GameMaster gameMaster;
    CinemachineBrain cinemachine;

    // Start is called before the first frame update
    void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spacecraftControls = GetComponent<SpacecraftControls>();
        trail = GameObject.Find("spacecraft_trail");
        spacecraftMovement = GetComponent<SpacecraftMovement>();
        spacecraftDeath = GetComponent<SpacecraftDeath>();
        cinemachine = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CinemachineBrain>();

        Vector2 lastCheckointPos = gameMaster.getLastCheckpointPos();
        if(lastCheckointPos != null)
        {
            trail.SetActive(false);
            transform.position = lastCheckointPos;
            trail.SetActive(true);
        }
        Quaternion spacecraftRotation = gameMaster.getSpacecraftRotation();
        if(spacecraftRotation != null)
        {
            transform.rotation = spacecraftRotation;
        }
    }

    public void DisableSpacecraft()
    {
        spacecraftControls.enabled = false;
        spriteRenderer.enabled = false;
        trail.SetActive(false);
        spacecraftMovement.enabled = false;        
    }

    public void enableSpacecraft()
    {
        spacecraftControls.enabled = true;
        spriteRenderer.enabled = true;
        trail.SetActive(true);
        spacecraftMovement.enabled = true;
    }

    public void levelComplete()
    {
        spacecraftMovement.disableMovement();
        spacecraftDeath.enabled = false;
        cinemachine.enabled = false;
        spacecraftMovement.increaseCraftSpeed(winSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EndGoal")
        {
            levelComplete();
        }
    }
}
