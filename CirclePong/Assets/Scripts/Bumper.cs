using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
    
{

    // Start is called before the first frame update
    //void Start()

    // Update is called once per frame

    public Transform ts;
   // public float bumpdistance;
    private Vector3 bumpVec;

    void Update()
    {
        // Bumper key
        bumpVec = new Vector3(4.5f, 0, 0);
        if (Input.GetKey("w"))
        {
            ts.localPosition = bumpVec;
        }
        else
        {
            ts.localPosition = new Vector3(5f, 0, 0);
                }

    }
}
