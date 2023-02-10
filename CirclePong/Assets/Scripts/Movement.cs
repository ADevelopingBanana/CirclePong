using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;

    public float center;
    public float lowerBound;
    public float upperBound;

    public Quaternion upperBoundAngle;
    public Quaternion lowerBoundAngle;

    public KeyCode upButton;
    public KeyCode downButton;
    
    public Rigidbody RB;
    public Transform ts;
    public Transform tst;

    private Vector3 velocityVector;
    private Vector3 nVelocityVector;


    void Start()
    {
        // Create velocity vectors
        velocityVector = new Vector3(0, Speed, 0);
        nVelocityVector = new Vector3(0, -Speed, 0);
    }
    void Update()
    {
        // If player is over center line
        if (ts.position.x < center)
        {
            // AND player is on bottom side
            if (ts.position.z < lowerBound)
            {
                // Set angular velocity to zero
                RB.angularVelocity = Vector3.zero;
                // Turn track angle to lower bound
                tst.rotation = lowerBoundAngle;
            }
            // AND player is on top side
            else if (ts.position.z > upperBound)
            {
                // Set angular velocity to zero
                RB.angularVelocity = Vector3.zero;
                // Turn track angle to upper bound
                tst.rotation = upperBoundAngle;
            }
        }
        // else (Player is on their side)
        else
        {
            // If pressing down button
            if (Input.GetKey(downButton))
            {
                // Set track velocity to velocityVector
                GetComponent<Rigidbody>().angularVelocity = velocityVector;
            }
            // elseIf pressing up button
            else if (Input.GetKey(upButton))
            {
                // Set track velocity to nVelocityVector
                GetComponent<Rigidbody>().angularVelocity = nVelocityVector;
            }
            else
            {
                // else (no button pressed) Set angular velocity to zero
                GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
        }
    }
}