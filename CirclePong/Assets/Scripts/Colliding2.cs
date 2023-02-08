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
         if (other.gameObject.tag == "Paddle2")
        {
            Debug.Log("Trigger Paddle2");
            Debug.Log(RB.velocity + "start2");
            normalVector = targetTransform2.position - fromTransform2.position;

            RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            Debug.Log(RB.velocity + normalVector);


        }
    }

}
