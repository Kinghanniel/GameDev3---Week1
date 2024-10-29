using System.Collections;
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
    private int currentWaveCount = 0;

    public void SpawnerLogic()
    {
        StartCoroutine(SpawnWave());
    }

     private IEnumerator SpawnWave()
    {
        for (int i = 0; i < numberOfEnemiesSpawned; i++)

        { 
            int randomInteger = Random.Range(0, spawnPoints.Length);
            GameObject spawnedShip = Instantiate(enemyPrefab, spawnPoints[randomInteger]);
            spawnedShip.GetComponent<EnemyVisual>().enemyData = enemyData[currentWaveCount];
            spawnedShip.GetComponent<EnemyMovement>().enemyData = enemyData[currentWaveCount];
            spawnedShip.GetComponent<EnemyLife>().enemyData = enemyData[currentWaveCount];
            yield return new WaitForSeconds(delayBetweenSpawns); 
        }

        currentWaveCount++;
        if (currentWaveCount > enemyData.Length)
        { 
            currentWaveCount = 0;
        }

        yield return new WaitForSeconds(delayBetweenWaves); 
        StartCoroutine(SpawnWave());

    }

}
