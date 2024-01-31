using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public float moveSpeed;
    public float Deceleration = -2;
    public float deadZone = -18.35f;

    private bool timer = true;

    public float Event = 15;


    // Update is called once per frame
    void Update()
    {
        Event -= Time.deltaTime;
        if (Event <= 0)
        {
            timer = false;
        }

        if (timer == true)
        {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }
        else
        {
            moveSpeed = moveSpeed - Deceleration * Time.deltaTime;
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

}
