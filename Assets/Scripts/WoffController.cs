using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoffController : MonoBehaviour
{
    [Header("Set in the Inspector")]
    public int flySpeed = 5;

    Vector3 forward = new Vector3(-1, 0, 0);
    Vector3 startPos = new Vector3(72, 0.11f, -5.23f);
    Vector3 endPos = new Vector3(38, 0.11f, -5.23f);


    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        //Once the trigger point has been hit
        //Check if the woff position is off screen to the left of camera and setactive is false. If so set it to true

        gameObject.transform.Translate(forward* Time.deltaTime * flySpeed, Space.World);

        //Check if woff position is off camera to the right of camera and setactive is true. If so set false and take position back to left
        if(gameObject.transform.position.x < endPos.x)
        {
            gameObject.transform.position = new Vector3(startPos.x, startPos.y, gameObject.transform.position.z);
        }
    }
}
