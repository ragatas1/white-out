using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSkript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

}
