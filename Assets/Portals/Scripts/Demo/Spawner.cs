using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randNum;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range(spawnMostWait, spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        yield
        return new WaitForSeconds(startWait);

        while (!stop)
        {
            randNum = Random.Range(0, 3);


            Instantiate(cubes[randNum],transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield
            return new WaitForSeconds(spawnWait);
        }
    }
}