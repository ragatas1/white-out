using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PappaFantDeg : MonoBehaviour
{
    
    public bool duS�Pappa = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            duS�Pappa = true;
        }
    }
    
}
