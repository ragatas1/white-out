using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PappaFantDeg : MonoBehaviour
{
    
    public bool duSÂPappa = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            duSÂPappa = true;
        }
    }
    
}
