using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PappaScript : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    public RopePappa ropePappa;
    public PappaFantDeg pf;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(vent());
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ropePappa.pappaSnakke == true && pf.duSÂPappa == false) 
        {
            StartCoroutine(lyd());
        }
    }


    IEnumerator lyd()
    {
        ropePappa.pappaSnakke = false;
        yield return new WaitForSeconds(1);
        source.clip = sounds[Random.Range (0,sounds.Length)];
        source.PlayOneShot(source.clip);
        yield return new WaitForSeconds(5);
        ropePappa.pappaSnakke = true;
    }

    IEnumerator vent()
    {
        ropePappa.pappaSnakke = false;
        ropePappa.kanSnakke = false;
        yield return new WaitForSeconds(3);
        source.PlayOneShot(source.clip);
        yield return new WaitForSeconds(5);
        ropePappa.kanSnakke = true;
        ropePappa.pappaSnakke = true;
    }
}
