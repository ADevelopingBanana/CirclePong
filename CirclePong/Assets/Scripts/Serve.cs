using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serve : MonoBehaviour
{
    private Vector3 bounceVelocity;
    public Rigidbody RB;
    public float serveSpeed;
    public int isParentedTo;
    public KeyCode serveButton;
    private bool firstServe = true;
 


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (firstServe == true && isParentedTo == 0)
        {
            int randomServe = Random.Range(0, 2);

            if (Input.GetKey(serveButton))
            {
                if (randomServe == 1)
                {
                GetComponent<Rigidbody>().velocity = new Vector3 (serveSpeed, 0, 0);
                }
                
                else
                {
                GetComponent<Rigidbody>().velocity = new Vector3 (-serveSpeed, 0, 0);
                }

                firstServe = false;
            }
        }
        else if (isParentedTo == 1)
        {
            if (Input.GetKey(serveButton))
            {
                GetComponent<Transform>().parent = null;
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Rigidbody>().velocity = serveSpeed * Vector3.Normalize(GameObject.Find ("Track1").transform.position - GameObject.Find("Player1").transform.position);
                isParentedTo = 0;
            }
        }

        else if (isParentedTo == 2)
        {
            if (Input.GetKey(serveButton))
            {
                GetComponent<Transform>().parent = null;
                GetComponent<Rigidbody>().isKinematic = false;
                GetComponent<Rigidbody>().velocity = serveSpeed * Vector3.Normalize(GameObject.Find ("Track1").transform.position - GameObject.Find("Player2").transform.position);
                isParentedTo = 0;
            }
        }
    }
}
