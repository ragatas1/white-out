using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Transform orientation;
    public float moveSpeed;
    [HideInInspector] public float horizontal;
    [HideInInspector] public float vertical;
    Vector3 moveDirection;
    Rigidbody rb;

    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        moveDirection = orientation.forward * vertical + orientation.right * horizontal;
        rb.AddForce(moveDirection.normalized*moveSpeed,ForceMode.Force);

        if (rb.velocity == Vector3.zero) 
        {
            Debug.Log("Stå stille");
            StartCoroutine(notMoving());
        }
        else if (rb.velocity.magnitude >= 0.01) 
        {
            StopAllCoroutines();
            timer.isMoving = true;
        }
        
    }

    IEnumerator notMoving()
    {
        yield return new WaitForSeconds(5);
        timer.isMoving = false;
    }
}
