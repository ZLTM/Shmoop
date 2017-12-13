using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] SpawnObject;
    public float XRange = 1.0f;
    public float YRange = 1.0f;
    public float MinSpawnTime = 1.0f;
    public float MaxSpawnTime = 5.0f;

    // Use this for initialization
    void Start()
    {
        Invoke("SpawnWall", Random.Range(MinSpawnTime, MaxSpawnTime));
    }

    void SpawnWall()
    {
        float XOffset = Random.Range(-XRange, XRange);
        float YOffset = Random.Range(-YRange, YRange);
        int SpawnObjectIndex = Random.Range(0, SpawnObject.Length);
        Instantiate(SpawnObject[SpawnObjectIndex], transform.position + new Vector3(XOffset, YOffset, 0.0f), SpawnObject[SpawnObjectIndex].transform.rotation);
        Invoke("SpawnWall", Random.Range(MinSpawnTime, MaxSpawnTime)); //invoke inside invoke, better controll than Invoke.repeat
    }

}
