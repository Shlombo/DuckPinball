using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressed : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject leftPaddle;
    private GameObject rightPaddle;

    void Start()
    {
        leftPaddle = GameObject.Find("Paddle Left");
        rightPaddle = GameObject.Find("Paddle Right");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");
 
        if (Input.GetKeyDown("left"))
        {
            print("Horizontal movement: " + horizontalValue);
            leftPaddle.transform.Rotate(90f, 0f, 0f, Space.World);
        }
 
        if(verticalValue != 0)
        {
            print("Vertical movement: " + verticalValue);
        }
    }
}

