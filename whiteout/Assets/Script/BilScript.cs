using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilScript : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
