using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCont : MonoBehaviour
{
    WheelJoint2D[] wheels;
    JointMotor2D jointMotor;
    float speed  = 0;
    void Start()
    {
        wheels = GameObject.Find("carBody").GetComponents<WheelJoint2D>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            speed-=100*Time.fixedDeltaTime;
            if (speed<=-2000) {
                speed = -2000;
            }
             jointMotor.motorSpeed = speed; 
             jointMotor.maxMotorTorque = 10000;

             wheels[0].motor = jointMotor;
             wheels[1].motor = jointMotor;
             Debug.Log (speed); 
        } 
        if(!Input.GetKey(KeyCode.Space)) {
            speed +=200*Time.fixedDeltaTime;
            if (speed >=0) {
                speed = 0;
            }
            jointMotor.motorSpeed = speed; 
            jointMotor.maxMotorTorque = 10000;

            wheels[0].motor = jointMotor;
            wheels[1].motor = jointMotor;
        }
    }
}
