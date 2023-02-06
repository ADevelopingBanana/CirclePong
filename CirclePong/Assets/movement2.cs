using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public float Velocity;
    Vector3 VelVec;
    Vector3 nVelVec;
    Vector3 zeroV = new Vector3(0, 0, 0);
    // public Vector3 angularVelocity = ; 
    private Rigidbody RB;

    void Start()
    {
        VelVec = new Vector3(0, Velocity, 0);
        nVelVec = new Vector3(0, -Velocity, 0);
    }
    void Update()
    {
        // Velocity = angularVelocity;
        if (Input.GetKey("j"))
        {
            GetComponent<Rigidbody>().angularVelocity = VelVec;
        }
        else if (Input.GetKey("l"))
        {
            GetComponent<Rigidbody>().angularVelocity = nVelVec;
        }
        else
        {
            GetComponent<Rigidbody>().angularVelocity = zeroV;
        }




    }
}