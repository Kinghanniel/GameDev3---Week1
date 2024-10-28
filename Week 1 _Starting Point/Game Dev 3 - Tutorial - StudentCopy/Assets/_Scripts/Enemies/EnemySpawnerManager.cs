using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float delayBetweenSpawns;
    [SerializeField] int numberOfEnemiesSpawned;
    [SerializeField] float delayBetweenWaves;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] EnemyData[] enemyData;
    [SerializeField] int wavesNumber;
    private int currentWaveCount = 0

     IEnumerator SpawnWave()
    {
        for (int i = 0; i < numberOfEnemiesSpawned; i++)

        { 
           int randomInteger = Random.Range(0, spawnPoints.Length);
            Gam
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
