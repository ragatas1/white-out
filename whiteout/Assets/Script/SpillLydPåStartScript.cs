using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpillLydPåStartScript : MonoBehaviour
{
    public AudioSource lyd;
    public AudioSource pappa;
    public AudioSource dor;


    // Start is called before the first frame update
    void Start()
    {
        lyd.Play();
        StartCoroutine(byttCene());
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.R)) {
            SceneManager.LoadScene("mindre sloppy scene");
        } 
    }

    IEnumerator byttCene()
    {
        yield return new WaitForSeconds(34);
        pappa.Play();
        yield return new WaitForSeconds(1);
        dor.Play();

    }
}
