using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding2 : MonoBehaviour
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
        
                Debug.Log("Trigger Collider2 Impact velocity = " + RB.velocity + "(Magnitude: " + RB.velocity.magnitude + ")" );
        
        if (other.gameObject.tag == "Paddle2")
        {
                Debug.Log("Trigger Paddle2 velocity = " + RB.velocity + "(Magnitude: " + RB.velocity.magnitude + ")" );
            
            normalVector = Vector3.Normalize(targetTransform2.position - fromTransform2.position);
            
                Debug.Log("normalVector = " + normalVector + "(Magnitude: " + normalVector.magnitude + ")" );
            
            RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            
                Debug.Log("Final Velocity1 = " + RB.velocity + "(Magnitude: " + RB.velocity.magnitude + ")" );

        }
    }

}
