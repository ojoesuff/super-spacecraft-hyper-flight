using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftMovement : MonoBehaviour
{
    public float rotateSpeed = 1f;
    public float craftSpeed = 1f;
    GameObject[] bgs;
    List<BackgroundController> bgControllers = new List<BackgroundController>();
    Vector3 previousPos;
    Vector3 currentPos;
    bool movementEnabled;

    // Start is called before the first frame update
    void Start()
    {
        movementEnabled = true;
        bgs = GameObject.FindGameObjectsWithTag("Background");
        foreach (GameObject bg in bgs)
            bgControllers.Add(bg.GetComponent<BackgroundController>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentPos = transform.position;
        accelerateCraft();
        previousPos = currentPos;
    }

    public void rotateCraft(float moveAmount)
    {
        if(movementEnabled)
        {
            transform.Rotate(0.0f, 0.0f, -moveAmount * rotateSpeed);
        }
        
    }

    public void accelerateCraft()
    {
        transform.position += transform.right * Time.deltaTime * craftSpeed;
        Vector3 movement = previousPos - currentPos;
        //Debug.Log("previous: " + previousPos + ", current: " + currentPos + ", movement: " + movement);
        if(movementEnabled)
        {
            foreach (BackgroundController bgController in bgControllers)
                bgController.scroll(movement);
        }
        
    }

    public void enableMovement()
    {
        movementEnabled = true;
    }

    public void disableMovement()
    {
        movementEnabled = false;
    }

    public void increaseCraftSpeed(float increaseSpeed)
    {
        craftSpeed *= increaseSpeed;
    }
    public void decreaseCraftSpeed(float decreaseSpeed)
    {
        craftSpeed /= decreaseSpeed;
    }
}
