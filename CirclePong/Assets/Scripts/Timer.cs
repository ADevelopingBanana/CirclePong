using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      GetComponent<TMPro.TextMeshProUGUI>().text = GameObject.Find ("GameController").GetComponent <GameControllerScript>().timer.ToString();
    }
}
