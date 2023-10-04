using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    public GameObject enemies;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        //Invoke("SpawnObject", 0.5f);
    }

    public void SpawnObject()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        Instantiate(enemies, currentPoint.transform.position, transform.rotation);
        
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}

/*public GameObject[] spawnPoints;
GameObject currentPoint;
int index;

public GameObject[] enemies;
public float minTimeBtwSpawns;
public float maxTimeBtwSpawns;
public int enemiesInRoom;
public bool canSpawn;
public bool stopSpawning = false;
public float spawnTime;
public float spawnDelay;*/

/*private void Update()
{
    if (canSpawn)
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            canSpawn = false;
        }
    }
}*/

/*index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        float timeBtwSpawns = Random.Range(minTimeBtwSpawns, maxTimeBtwSpawns);

        if (canSpawn)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
            enemiesInRoom++;
        }

        Invoke("SpawnObject", timeBtwSpawns);*/