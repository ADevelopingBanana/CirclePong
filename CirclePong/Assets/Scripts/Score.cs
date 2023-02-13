using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find ("GameController").GetComponent <GameControllerScript>().p1Score +" - " + GameObject.Find ("GameController").GetComponent <GameControllerScript>().p2Score;
        
    }
}
