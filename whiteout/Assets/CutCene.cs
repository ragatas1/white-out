using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CutCene : MonoBehaviour
{
    public float speed = 2f;
    public float maxRotation = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(maxRotation * Mathf.Sin(Time.time * speed), 0f, 0f);
    }
}
