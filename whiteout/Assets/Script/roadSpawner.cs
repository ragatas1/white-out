using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadSpawner : MonoBehaviour
{
    public GameObject Tree;
    private float timer = 0;
    public float spawnRate = 1;
    public float heightOffset = 40;

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnTree();
            timer = 0;
        }
    }

    void spawnTree()
    {

        float lowestPoint = transform.position.z - heightOffset;
        float highestPoint = transform.position.z + heightOffset;
        Instantiate(Tree, new Vector3(transform.position.x, 0, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
