using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHoldeScript : MonoBehaviour
{
    GameObject kamera;
    Transform kameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.FindGameObjectWithTag("MainCamera");
        kameraTransform = kamera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        kameraTransform = transform;
    }
}
