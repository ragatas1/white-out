using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuFantPappa : MonoBehaviour
{
    
    public AudioSource lyd;
    public PappaFantDeg pf;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space) && pf.duSÂPappa == true)
        {
            StartCoroutine(gameOver());
        }
    }

    

    IEnumerator gameOver()
    {
        pf.duSÂPappa = false;
        yield return new WaitForSeconds(1);
        lyd.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");
    }
    
}
