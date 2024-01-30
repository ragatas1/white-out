using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpookScript : MonoBehaviour
{
    public GameObject spooks;
    public Transform rotera;
    public Transform spiller;
    public float maksTid;
    public float minTid;
    float tid;
    public bool stfu;
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
            rotera.position = spiller.position;
            rotera.Rotate(0, 1, 0);
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
}
