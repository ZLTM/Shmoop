using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject[] Wall;
    public Vector2 PositionRange = Vector2.one;
    public float MinSpawnTime = 1.0f;
    public float MaxSpawnTime = 5.0f;

    // Use this for initialization
    void Start()
    {
        Invoke("SpawnWall", Random.Range(MinSpawnTime, MaxSpawnTime));
    }

    void SpawnWall()
    {
        Invoke("SpawnWall", Random.Range(MinSpawnTime, MaxSpawnTime)); //invoke inside invoke, better controll than Invoke.repeat
    }

}
