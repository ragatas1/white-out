using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float standStill = 10;
    public float Event = 0;

    private bool timer = true;
    public bool isMoving = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( isMoving == true)
        {
            Event += Time.deltaTime;
        }
        else if (isMoving == false)
        {
            Event += Time.deltaTime * standStill;
        }
       
    }
}
