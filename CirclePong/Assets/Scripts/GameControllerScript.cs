using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unfinished

public class GameControllerScript : MonoBehaviour
{
    // Public variables. Can be referenced with GameObject.Find ("GameController").GetComponent <GameControllerScript>().variableName;
    public int p1Score;
    public int p2Score;
    public int timer;
    public int timeLimit;
    public int scoreLimit;
    public float speedUpRate = 1.01f;


    void Start()
    {
        // Initialize scores and timer when game starts
        p1Score = 0;
        p2Score = 0;
        timer = 0; 
    }

    // ScorePoint function. Can be called with -- GameObject.Find ("GameController").GetComponent <GameControllerScript>().ScorePoint(isPlayer1); -- Replace "isPlayer1" with true or false.
    public void ScorePoint(bool isPlayer1)
    {
        // If Player 1
        if (isPlayer1 == true)
        {
            p1Score ++;
        }
        // else (Player2)
        else 
        {
            p2Score ++;
        }
        Debug.Log("P1: " + GameObject.Find ("GameController").GetComponent <GameControllerScript>().p1Score + "P2: " + GameObject.Find ("GameController").GetComponent <GameControllerScript>().p2Score);

        // End game if score limit is reached

        // Make a new ball if score limit isn't reached
    }

    void Update()
    {
        
    }

}
