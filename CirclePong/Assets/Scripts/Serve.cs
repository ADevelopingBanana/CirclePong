using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serve : MonoBehaviour
{
    private Vector3 bounceVelocity;
    public Rigidbody RB;
    public float serveSpeed;
 


    // Start is called before the first frame update
    void Start()
    {
        
        RB.velocity = new Vector3(serveSpeed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
