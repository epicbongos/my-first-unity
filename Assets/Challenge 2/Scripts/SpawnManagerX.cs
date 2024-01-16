using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;
    private float spawnInterval2 = 5.0f;
    private List<GameObject> instatiatedBalls = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        float spawnIntervalNew = Random.Range(spawnInterval, spawnInterval2);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnIntervalNew);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position

        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        GameObject newBall = Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        instatiatedBalls.Add(newBall);
    }

}
