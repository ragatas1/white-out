using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillLydPåStartScript : MonoBehaviour
{
    public AudioSource lyd;
    // Start is called before the first frame update
    void Start()
    {
        lyd.Play();
    }

}
