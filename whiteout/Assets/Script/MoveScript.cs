using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public bool grounded;
    public LayerMask ground;
    public Transform groundCheck;
    public Transform orientation;

    private float moveSpeed;
    public float walkspeed;
    public float sprintSpeed;

    public KeyCode sprintKey = KeyCode.LeftShift;

    [HideInInspector] public float horizontal;
    [HideInInspector] public float vertical;

    Vector3 moveDirection;
    Rigidbody rb;

    public Timer timer;

    public MovementState state;
    public GroundCheckScript checkScript;

    public enum MovementState
    {
        walking,
        sprinting
    }

    private void StateHandler ()
    {
        if(Input.GetKey(sprintKey))
        {
            state = MovementState.sprinting;
            moveSpeed = sprintSpeed;
        }

        else
        {
            state = MovementState.walking;
            moveSpeed = walkspeed;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        StateHandler();

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        moveDirection = orientation.forward * vertical + orientation.right * horizontal;
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);


       /* 
        if (IsGrounded())
        {
            this.rb.useGravity = false;
            grounded = true;
        }
        else
        {
            this.rb.useGravity = true;
            rb.AddForce(Physics.gravity * rb.mass * 2);
            grounded = false;
        }
       */
    }
    
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
    }
    
    
}
