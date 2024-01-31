using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer2 : MonoBehaviour
{
    public bool timer = true;

    public float Event = 10;


    // Update is called once per frame
    void Update()
    {
        Event -= Time.deltaTime;

        if (Event <= 0)
        {
            timer = false;
        }
    }
}
