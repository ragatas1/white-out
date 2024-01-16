using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    bool up;
    public float bobspeed;
    public float bobtimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y+bobspeed*Time.deltaTime,transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - bobspeed * Time.deltaTime, transform.position.z);
        }
        bobtimer = bobtimer + 1 * Time.deltaTime;
        if (bobtimer < 1)
        {

        }
    }
}
