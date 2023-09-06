using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    private HingeJoint2D hingeJoint;
    private JointMotor2D motor;
    private int paddleNum;
    
    
    public enum PaddleType {left,right};

    
    public PaddleType paddleTypeSelection;
    public float paddleSpeed = 500f; // Adjust this speed to control the paddle's movement.
    
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint2D>();
        motor = hingeJoint.motor;

        // if(paddleType == paddleType.right) {
        //     paddleNum = 
        // }
    }

    void Update()
    {
        // Control paddle movement
        float input = Input.GetAxis("Horizontal") ; // Use horizontal input axis (e.g., A/D or Left/Right arrow keys).
        if(input < 0 && paddleTypeSelection == PaddleType.left) {
            motor.motorSpeed = input * paddleSpeed;
        } else if(input > 0 && paddleTypeSelection == PaddleType.right) {
            motor.motorSpeed = input * paddleSpeed;
        } else {
            if(paddleTypeSelection == PaddleType.left) {
                motor.motorSpeed = paddleSpeed;
            } else {
                motor.motorSpeed = -paddleSpeed;
            }
        }
        hingeJoint.motor = motor;
    }
}

