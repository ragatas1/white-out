using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuFantPappa : MonoBehaviour
{
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            Debug.Log("Collided");
        }
    }
}
