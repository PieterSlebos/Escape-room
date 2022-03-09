using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject ball;
    public Transform SpawnPoint;
    public GameObject coin;

    public float maxX;
    public float pointZ;
    public float minX;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnBall", 5f, 0.2f);
        InvokeRepeating("spawnCoin", 10f, 10f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnCoin()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, pointZ);

        Instantiate(coin, randomSpawnPos, Quaternion.identity);


    }
    void spawnBall()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 randomSpawnPos = new Vector3(randomX, 10f, pointZ);

        Instantiate(ball, randomSpawnPos, Quaternion.identity);
        ball.tag = "Enemy";

    }
}
