using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Unfinished

public class GameControllerScript : MonoBehaviour
{
    // Public variables. Can be referenced with GameObject.Find ("GameController").GetComponent <GameControllerScript>().variableName;
    public int p1Score;
    public int p2Score;
    public float timer;
    public int timeLimit;
    public int scoreLimit;
    public float speedUpRate = 1.01f;
    public Vector3 ballServeOffset;
    public GameObject BallPrefab;
    public GameObject P1Paddle;
    public GameObject P2Paddle;
    public GameObject P1Track;
    public GameObject P2Track;
    private GameObject BallClone;
    private float currentTime;
    private int isParentedTo;


    void Start()
    {
        // Initialize scores and timer when game starts
        p1Score = 0;
        p2Score = 0;
        timer = 0;
        currentTime = timeLimit;
    }

    // ScorePoint function. Can be called with -- GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(isPlayer1); -- Replace "isPlayer1" with true or false.
    public void ScorePoint(bool isPlayer1)
    {
    // Add point to respective player
        // If Player 1
        if (isPlayer1 == true)
        {
            // Add 2 to p2Score
            p1Score ++;
        }
        // else (Player2)
        else 
        {
            // Add 1 to p2Score
            p2Score ++;
        }
    // Check if players reached max score, go to end screen for player if so and make new ball if not
        // If player 1 reached score limit
        if(p1Score >= scoreLimit)
        {
            // Go to player 1 win scene
        }
        // Else if player 2 reached score limit
        else if (p2Score >= scoreLimit)
        {
            // Go to player 2 win scene
        }
        // Else (no player hit score limit)
        else
        {
        // Make a new ball as child of scoring player
            if (isPlayer1 == true)
            {
                BallClone = Instantiate(BallPrefab, P1Paddle.transform.position, P1Paddle.transform.rotation, P1Track.transform);
                isParentedTo = 1;
            }
            else if (isPlayer1 == false)
            {
               BallClone = Instantiate(BallPrefab, P2Paddle.transform.position, P1Paddle.transform.rotation, P2Track.transform);
               isParentedTo = 2;
            }
            // Do stuff to new ball 
            Rigidbody NewBallRB = BallClone.GetComponent<Rigidbody>();
            NewBallRB.velocity = Vector3.zero;
            NewBallRB.isKinematic = true;
            BallClone.GetComponent<Serve>().isParentedTo = isParentedTo;
        }

        
    }

    void Update()
    {
        //Decrement currentTime
        currentTime -= 1 * Time.deltaTime;
        //Round to int and set timer to result
        timer =  (int)Math.Round(currentTime, 0);

        if(timer <= 0)
        {
            Debug.Log("Game Over");
            //End Game
        }
    }

}
