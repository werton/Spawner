using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;

    private Coroutine _spawnCoroutine;

    public void StartInstantSpawn(float spawnDelay)
    {
        _spawnCoroutine = StartCoroutine(SpawnCoroutine(spawnDelay));
    }

    public void StopInstantSpawn()
    {
        StopCoroutine(_spawnCoroutine);
    }

    public void Spawn(Vector3 position)
    {
        Instantiate(_enemyTemplate, position, Quaternion.identity);
    }

    private IEnumerator SpawnCoroutine(float delay)
    {
        bool isSpawnStarted = true;

        while (isSpawnStarted == true)
        {
            Spawn(transform.position);

            yield return new WaitForSeconds(delay);
        }
    }
}