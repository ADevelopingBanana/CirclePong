using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public Rigidbody RB;
    public float bouncePower;
    public Transform fromTransform;
    public Transform targetTransform;
    private Vector3 normalVector;
    public Transform fromTransform2;
    public Transform targetTransform2;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Collider");
        if (other.gameObject.tag == "Paddle")
        {
            Debug.Log("Trigger Paddle1");
            Debug.Log(RB.velocity + "start1");
            normalVector = targetTransform.position - fromTransform.position;

            RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            Debug.Log(RB.velocity + normalVector);

        }
        
    }
   
}
