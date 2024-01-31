using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{
    public bool grounded;
    public Rigidbody rb;
    public Transform spiller;
    public float tyngdekraft;

    private void Update()
    {
        rb.useGravity = !grounded;
        if (!grounded) 
        {
             rb.velocity = new Vector3(rb.velocity.x,tyngdekraft,rb.velocity.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "bakke")
        {
            grounded = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "bakke")
        {
            grounded = false;
        }
    }
}
