using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Rigidbody RB;
    public float bouncePower;
    private Vector3 bounceVelocity;
  
    void OnTriggerExit(Collider other)
    {
       if (other.gameObject.tag == "Paddle")
        {
            bounceVelocity = new Vector3(RB.velocity.x + (RB.velocity.x* bouncePower), RB.velocity.y + (RB.velocity.y* bouncePower), RB.velocity.z + (RB.velocity.z* bouncePower));
            RB.velocity = bounceVelocity;

        }
    }
}
