using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float enemySpawnRangeZ = 14.0f;
    private float spawnRangeX = 20.0f;
    private float spawnRangeY = 1.0f;
    private float powerupSpawnRangeZ = 5f;

    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;

    void Start()
    {
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPosition = new Vector3(randomX, spawnRangeY, enemySpawnRangeZ);

        Instantiate(enemies[randomIndex], spawnPosition, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomZ = Random.Range(-powerupSpawnRangeZ, powerupSpawnRangeZ);

        Vector3 spawnPosition = new Vector3(randomX, spawnRangeY, randomZ);

        Instantiate(powerup, spawnPosition, powerup.gameObject.transform.rotation);
    }
}
