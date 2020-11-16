using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftControls : MonoBehaviour
{
    SpacecraftMovement spacecraftMovement;
    // Start is called before the first frame update
    void Start()
    {
        spacecraftMovement = GetComponent<SpacecraftMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        if(horizontalMovement != 0)
        {
            spacecraftMovement.rotateCraft(horizontalMovement);
        }
        
    }
}
