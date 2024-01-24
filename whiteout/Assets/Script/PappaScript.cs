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

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(vent());
        source = GetComponent<AudioSource>();
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

        yield return new WaitForSeconds(2);
        source.clip = sounds[Random.Range (0,sounds.Length)];
        source.PlayOneShot(source.clip);
        kanSnakke = false;
        yield return new WaitForSeconds(5);
        kanSnakke = true;
    }

    IEnumerator vent()
    {
        kanSnakke = false;
        yield return new WaitForSeconds(4);
        source.PlayOneShot(source.clip);
        yield return new WaitForSeconds(5);
        kanSnakke = true;
    }
}
