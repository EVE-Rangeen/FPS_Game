using UnityEngine;
using Unity.FPS.Game;

public class BossController : MonoBehaviour
{
    [Header("Boss Parameters")]
    [Tooltip("Dont Touch!!!")]
    public float BossHealth = 100f;
    [Header("Spawn Parameters")]
    public float FirstWaveSpawnHealth = 100f;

    public float SecondWaveSpawnHealth = 100f;
    public bool SpawnWave1Enabled = true;
    public bool SpawnWave2Enabled = true;
    [Tooltip("The prefab to spawn at the first wave")]
    public GameObject EnemyPrefab1;
    [Tooltip("The prefab to spawn at the second wave")]
    public GameObject EnemyPrefab2;
    public int NumberOfEnemiesToSpawn = 3;
    public float SpawnRadius = 5f;

    private Health healthComponent;

    void Start()
    {
        healthComponent = GetComponent<Health>();
        if (healthComponent == null)
        {
            Debug.LogError("Health component not found on Boss!");
        }
        else
        {
            BossHealth = healthComponent.CurrentHealth;
        }
        Debug.Log("BossController script has started.");
        Debug.Log($"Initial BossHealth: {BossHealth}");
    }

    void Update()
    {
        if (healthComponent != null)
        {
            BossHealth = healthComponent.CurrentHealth;
        }

        Debug.Log($"BossHealth: {BossHealth}, SpawnWave1Enabled: {SpawnWave1Enabled}, SpawnWave2Enabled: {SpawnWave2Enabled}");

        // Spawn enemies when boss health is below 500
        if (BossHealth < FirstWaveSpawnHealth && SpawnWave1Enabled)
        {
            Debug.Log("Spawning enemies for wave 1!");
            SpawnEnemiesWave1();
            SpawnWave1Enabled = false; // Prevent multiple spawns for wave 1
        }

        // Spawn enemies when boss health is below 300
        if (BossHealth < SecondWaveSpawnHealth && SpawnWave2Enabled)
        {
            Debug.Log("Spawning enemies for wave 2!");
            SpawnEnemiesWave2();
            SpawnWave2Enabled = false; // Prevent multiple spawns for wave 2
        }
    }

    void SpawnEnemiesWave1()
    {
        for (int i = 0; i < NumberOfEnemiesToSpawn; i++)
        {
            Vector3 spawnPosition = transform.position + (Random.insideUnitSphere * SpawnRadius);
            spawnPosition.y = transform.position.y; // Keep the same height as the boss
            Instantiate(EnemyPrefab1, spawnPosition, Quaternion.identity);
        }
    }

    void SpawnEnemiesWave2()
    {
        for (int i = 0; i < NumberOfEnemiesToSpawn; i++)
        {
            Vector3 spawnPosition = transform.position + (Random.insideUnitSphere * SpawnRadius);
            spawnPosition.y = transform.position.y; // Keep the same height as the boss
            Instantiate(EnemyPrefab2, spawnPosition, Quaternion.identity);
        }
    }
}