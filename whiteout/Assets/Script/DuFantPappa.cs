using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuFantPappa : MonoBehaviour
{
    public AudioSource lyd;


    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            Debug.Log("Collided");
            StartCoroutine(gameOver());
        }
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(2);
        lyd.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");
    }
}
