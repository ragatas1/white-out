using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    bool up;
    public float bobIntensitet;
    public float bobFrekvens;
    public MoveScript moveScript;
    float bobtimer;
    public AudioClip[] sounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveScript.horizontal != 0 || moveScript.vertical != 0)
        {
            if (up)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + bobIntensitet * Time.deltaTime, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - bobIntensitet * Time.deltaTime, transform.position.z);
            }
            bobtimer = bobtimer + 1 * Time.deltaTime;
            if (bobtimer > bobFrekvens)
            {
                if (up)
                {
                    up = false;
                }
                else
                {
                    up = true;
                }
                bobtimer = 0;
                source.clip = sounds[Random.Range(0, sounds.Length)];
                source.PlayOneShot(source.clip);
            }
        }
    }
}
