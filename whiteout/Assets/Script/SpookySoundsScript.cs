using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookySoundsScript : MonoBehaviour


{
    public AudioSource soundEffect;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
    soundEffect.Play();
}
}
