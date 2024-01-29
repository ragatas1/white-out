using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuFantPappa : MonoBehaviour
{
    public AudioSource lyd;
    public bool duS�Pappa = false;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            lyd.Play();
        }
    }
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player" && duS�Pappa == true)
        {
            Debug.Log("Collided");
            StartCoroutine(gameOver());
        }
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");
    }
}
