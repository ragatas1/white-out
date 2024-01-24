using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilScript : MonoBehaviour
{
    public AudioSource dor;
    private void Start()
    {
        dor.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
