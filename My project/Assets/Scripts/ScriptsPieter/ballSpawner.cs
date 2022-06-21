using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{
    public float maxX;
    public float pointZ;
    public float minX;

    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;

        InvokeRepeating("spawnBall", 5f, 0.9f);
        InvokeRepeating("spawnCoin", 5f, 3f);
    }
  
    void spawnCoin()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, pointZ);

        objectPooler.SpawnFromPool("Coin", randomSpawnPos, Quaternion.identity);

    }
    void spawnBall()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, pointZ);
        GameObject ball = objectPooler.SpawnFromPool("Ball", randomSpawnPos, Quaternion.identity);
        ball.tag = "Enemy";

    }
}
