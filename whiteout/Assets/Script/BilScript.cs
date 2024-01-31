using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilScript : MonoBehaviour
{
    public AudioSource dor;
    public AudioSource kjore;
    public float fart;
    public float topPoint;
    public float hvorLengeVente;
    bool flyOpp;
    private void Start()
    {
        dor.Play();
    }
    private void Update()
    {
        if (flyOpp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + fart * Time.deltaTime, transform.position.z);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(kjorBort());
        }
    }
    IEnumerator kjorBort()
    {
        kjore.Play();       
        yield return new WaitForSeconds(hvorLengeVente);
        flyOpp = true;
        yield return new WaitUntil(() => transform.position.y > topPoint);
        Destroy(gameObject);
    }
}
