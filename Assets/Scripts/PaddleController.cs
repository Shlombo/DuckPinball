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
        if(paddleTypeSelection == PaddleType.left) {
            if(Input.GetButton("Left")) {
                motor.motorSpeed = -paddleSpeed;
                hingeJoint.motor = motor;
            } else {
                motor.motorSpeed = paddleSpeed;
                hingeJoint.motor = motor;
                motor.motorSpeed = 0;
            }
        } else {
            if(Input.GetButton("Right")) {
                motor.motorSpeed = paddleSpeed;
                hingeJoint.motor = motor;
            } else {
                motor.motorSpeed = -paddleSpeed;
                hingeJoint.motor = motor;
                motor.motorSpeed = 0;
            }
        }
    }
}

