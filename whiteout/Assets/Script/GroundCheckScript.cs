using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckScript : MonoBehaviour
{
    public bool grounded;
    public Rigidbody rb;

    private void Update()
    {
        rb.useGravity = !grounded;
    }
    private void OnTriggerEnter(Collider other)
    {
        grounded = true;
    }
    private void OnTriggerExit(Collider other)
    {
        grounded = false;
    }
}
