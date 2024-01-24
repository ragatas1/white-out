using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpillLydPåStartScript : MonoBehaviour
{
    public AudioSource lyd;


    // Start is called before the first frame update
    void Start()
    {
        lyd.Play();
        StartCoroutine(byttCene());
    }

    IEnumerator byttCene()
    {
        yield return new WaitForSeconds(34);
        SceneManager.LoadScene("Emilie");
    }
}
