using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; // Drag your prefab here in Inspector
    [SerializeField] private float spawnInterval = 3.5f; // Time between spawns
    [SerializeField] private float spawnRange = 10f; // Radius area to spawn within

    void Start()
    {
        // Start the timed spawning loop
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        // Calculate a random position on the X and Z axes (keeping Y at spawner height)
        Vector3 randomOffset = new Vector3(Random.Range(-spawnRange, spawnRange), 0, Random.Range(-spawnRange, spawnRange));
        Vector3 spawnPosition = transform.position + randomOffset;

        // Instantiate (spawn) the enemy prefab
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}

