using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    //pixels of bg sprite
    private float width;
    private float height;
    private GameObject cam;
    private Vector3 camPos;
    public float speed;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        width = boxCollider.size.x;
        height = boxCollider.size.y;
        cam = GameObject.FindGameObjectWithTag("MainCamera");        
        //Debug.Log("width" + width);
        //Debug.Log("height" + height);

    }

    private void Update()
    {
        //Debug.Log("camPos: " + camPos);
        float xPos = transform.position.x;
        float camXPos = cam.transform.position.x;
        float yPos = transform.position.y;
        float camYPos = cam.transform.position.y;
        //Debug.Log($"X Camera: {camXPos}, BG: {xPos}");
        //Debug.Log($"Y Camera: {camYPos}, BG: {yPos}");
        if (xPos + width < camXPos)
        {
            transform.position += new Vector3(width * 2, 0, 0);
        }
        if (camXPos + width < xPos)
        {
            transform.position -= new Vector3(width * 2, 0, 0);
        }
        if (yPos + height < camYPos)
        {
            transform.position += new Vector3(0, height * 2, 0);
        }
        if (camYPos + height < yPos)
        {
            transform.position -= new Vector3(0, height * 2, 0);
        }

    }

    public void scroll(Vector3 movement)
    {
        //background scroll opposite direction to craft
        transform.position += movement * speed;
    }
}
