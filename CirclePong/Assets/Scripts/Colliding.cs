using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    Vector3 normalVector;
    void OnTriggerEnter(Collider other)
    {
        // If colliding with Player1
        if (other.gameObject.tag == "Paddle")
        {
            // Get components
            Transform playerTransform = GameObject.Find ("Player1").GetComponent <Transform>();
            Transform trackTransform = GameObject.Find ("Track1").GetComponent <Transform>();
            Rigidbody RB = gameObject.GetComponent <Rigidbody>();

            // Calculate normalVector 
            normalVector = Vector3.Normalize(trackTransform.position - playerTransform.position);

            // Calculate and return reflected Velocity as Vector3
            RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            


        }
        // If colliding with Player2   
        else if (other.gameObject.tag == "Paddle2")
        {
            // Get components 
            Transform playerTransform = GameObject.Find ("Player2").GetComponent <Transform>();
            Transform trackTransform = GameObject.Find ("Track2").GetComponent <Transform>();
            Rigidbody RB = gameObject.GetComponent <Rigidbody>();


            // Calculate normalVector
            normalVector = Vector3.Normalize(playerTransform.position - trackTransform.position);

            // Calculate and return reflected Velocity as Vector3
            RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            


        }
    }

}
