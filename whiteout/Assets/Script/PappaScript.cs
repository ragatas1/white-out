using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PappaScript : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    bool kanSnakke = true;

    public AudioSource pappaLyd;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(vent());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && kanSnakke == true) 
        {
            StartCoroutine(lyd());
        }
    }

    IEnumerator lyd()
    {
        source.clip = sounds[Random.Range (0,sounds.Length)];
        source.PlayOneShot(source.clip);
        kanSnakke = false;
        yield return new WaitForSeconds(0);
        kanSnakke = true;
    }

    IEnumerator vent()
    {
        kanSnakke = false;
        yield return new WaitForSeconds(0);
        pappaLyd.Play();
        yield return new WaitForSeconds(0);
        kanSnakke = true;
    }
}
