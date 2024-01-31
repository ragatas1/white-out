using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpookScript : MonoBehaviour
{
    public GameObject spooks;
    public Transform spillerrotasjon;
    public Transform rotera;
    public Transform spiller;
    public float maksTid;
    public float minTid;
    float tid;
    bool stfu;
    bool pingPong;
    public bool nei;
    // Start is called before the first frame update
    void Start()
    {
        stfu = false;
        StartCoroutine(skummel());
    }
    private void Update()
    {
        if (!stfu)
        {
            spillerrotasjon.position = spiller.position;
            spillerrotasjon.rotation = spiller.rotation;
            if (pingPong )
            {
                rotera.Rotate(0, 0.3f, 0);
            }
            else
            {
                rotera.Rotate(0, -0.3f, 0);
            }
        }
    }
    IEnumerator skummel()
    {
        tid = Random.Range(minTid, maksTid);
        yield return new WaitForSeconds(tid);
        stfu = true;
        Instantiate(spooks, transform.position, transform.rotation);
        StartCoroutine(skummel());
        yield return new WaitForSeconds(5);
        stfu = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (pingPong)
        {
            pingPong = false;
        }
        else
        {
            pingPong = true;
        }
    }

}
