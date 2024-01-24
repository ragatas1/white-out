using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePappa : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    bool kanSnakke = true;

    // Start is called before the first frame update
    void Start()
    {
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
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.PlayOneShot(source.clip);
        kanSnakke = false;
        yield return new WaitForSeconds(3);
        kanSnakke = true;
    }

}
