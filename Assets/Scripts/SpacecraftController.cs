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

    CinemachineBrain cinemachine;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spacecraftControls = GetComponent<SpacecraftControls>();
        trail = GameObject.Find("spacecraft_trail");
        spacecraftMovement = GetComponent<SpacecraftMovement>();
        spacecraftDeath = GetComponent<SpacecraftDeath>();
        cinemachine = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CinemachineBrain>();
    }

    public void DisableSpacecraft()
    {
        spacecraftControls.enabled = false;
        spriteRenderer.enabled = false;
        trail.SetActive(false);
        spacecraftMovement.enabled = false;        
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
