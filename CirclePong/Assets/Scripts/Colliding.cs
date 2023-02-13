using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    Vector3 normalVector;
    void OnTriggerEnter(Collider collidedObject)
    {
        Debug.Log("goal");
        if(collidedObject.tag == "Goal")
        {
            if (collidedObject.transform.position.x < 0)
            {
                GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(true);
            }
            else if (collidedObject.transform.position.x >= 0)
            {
               GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(false); 
            }
            
            Destroy(gameObject);
        }

        // Get Rigidbody Component
        Rigidbody RB = gameObject.GetComponent <Rigidbody>();

        // Calculate normalVector 
        normalVector = GameObject.Find ("GameController").GetComponent <GameControllerScript>().speedUpRate * Vector3.Normalize(GameObject.Find ("Track1").transform.position - collidedObject.transform.position);

        // Calculate and return reflected Velocity as Vector3
        RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            
    }

}
