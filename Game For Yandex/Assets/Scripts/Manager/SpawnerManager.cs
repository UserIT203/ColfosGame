using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public float spawnRadius = 10f;

    public GameObject enemyPrefab;
    public float startTimeToSpawn = 10f;
    private float timeToSpawn;

    private void Start()
    {
        timeToSpawn = startTimeToSpawn;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }

    private void Update()
    {
        if (timeToSpawn <= 0)
        {
            float rndX = Random.Range(transform.position.x - spawnRadius, transform.position.x + spawnRadius);
            float rndZ = Random.Range(transform.position.z - spawnRadius, transform.position.z + spawnRadius);

            Instantiate(enemyPrefab, new Vector3(rndX, 2, rndZ), Quaternion.identity);
            timeToSpawn = startTimeToSpawn;
        }
        else
            timeToSpawn -= Time.deltaTime;
    }
}
