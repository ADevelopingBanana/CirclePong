using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{

    
    Vector3 normalVector;
    float maxSpeed;
    float speedUpRate;

    void Start()
    {
        maxSpeed = GameObject.Find ("GameController").GetComponent <GameControllerScript>().maxSpeed;
        speedUpRate = GameObject.Find ("GameController").GetComponent <GameControllerScript>().speedUpRate;
    }
    void OnTriggerEnter(Collider collidedObject)
    {

        //If colliding with a goal and..
        if(collidedObject.tag == "Goal")
        {
            // If on player 2 side
            if (collidedObject.transform.position.x < 0)
            {
                // Call ScorePoint function with isPlayer1 = true
                GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(true);
            }
            
            // Else if on player 1 side
            else if (collidedObject.transform.position.x >= 0)
            {
                // Call ScorePoint function with isPlayer1 = false
                GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(false); 
            }
            
            // Delete the ball
            Destroy(gameObject);
        }

        // Get Rigidbody Component
        Rigidbody RB = gameObject.GetComponent <Rigidbody>();

        // Calculate normalVector 
        normalVector = Vector3.Normalize(GameObject.Find ("Track1").transform.position - collidedObject.transform.position);

        Debug.Log("speed = " + RB.velocity.magnitude);
        Debug.Log("Maxspeed = " + maxSpeed);

        // Accelerate if not over max speed
        if (RB.velocity.magnitude < maxSpeed)
        {
            Debug.Log("acclerated ball");
            normalVector *= speedUpRate;
            Debug.Log("new speed = " + RB.velocity.magnitude);
        }

        // Calculate and return reflected Velocity as Vector3
        RB.velocity = Vector3.Reflect(RB.velocity, normalVector);
            
    }

}
