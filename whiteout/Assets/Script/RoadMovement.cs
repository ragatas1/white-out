using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public float moveSpeed;
    public float Deceleration = -2;
    public float deadZone = -18.35f;

    public Timer2 timer2;

    private void Start()
    {
        timer2 = GameObject.FindGameObjectWithTag("Logic").GetComponent<Timer2>();
    }
    // Update is called once per frame
    void Update()
    {
        if (timer2.timer == true)
        {
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }
        else
        {
            moveSpeed = moveSpeed - Deceleration * Time.deltaTime;
            transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
        }

        if (moveSpeed > 0)
        {
            moveSpeed = 0;
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

}
