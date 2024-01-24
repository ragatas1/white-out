using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PappaScript : MonoBehaviour
{
    public AudioSource pappaLyd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            pappaLyd.Play();
        }
    }
}
