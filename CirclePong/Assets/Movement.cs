using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Velocity;
    Vector3 VelVec;
    Vector3 nVelVec;
    Vector3 zeroV = new Vector3(0, 0, 0);
    public Rigidbody RB;
    public Transform ts;
    public Transform tst;
    public float center;
    public float rightBound;
    public float leftBound;
    public float verticalPos;
    ///public Vector3 activeBound;
    public Quaternion leftactiveBound;
    public Quaternion rightactiveBound;

    void Start()
    {
        VelVec = new Vector3(0, Velocity, 0);
        nVelVec = new Vector3(0, -Velocity, 0);
    }
    void Update()
    {
        Debug.Log(ts.position.z);
        if (ts.position.x < center)
        {
           // Debug.Log("centertrigger");


            if (ts.position.z < rightBound)
            {
                Debug.Log("righttrigger");
                RB.angularVelocity = Vector3.zero;
                tst.rotation = rightactiveBound;
            }
            else if (ts.position.z > leftBound)
            {
                Debug.Log("lefttrigger");
                RB.angularVelocity = Vector3.zero;
                tst.rotation = leftactiveBound;
            }
        }
        else
        {
            if (Input.GetKey("a"))
            {
                GetComponent<Rigidbody>().angularVelocity = VelVec;
            }
            else if (Input.GetKey("d"))
            {
                GetComponent<Rigidbody>().angularVelocity = nVelVec;
            }
            else
            {
                GetComponent<Rigidbody>().angularVelocity = zeroV;
            }
        }
    }
}