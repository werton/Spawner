using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyTemplate;
    [SerializeField] private float _spawnDelay;

    private Coroutine _spawnCoroutine;

    void Start()
    {
        StartInstantSpawn();
    }

    private void StartInstantSpawn()
    {
        
        _spawnCoroutine = StartCoroutine(SpawnCoroutine(_spawnDelay));
    }

    private void StopInstantSpawn()
    {

        StopCoroutine(_spawnCoroutine);
    }

    private void Spawn(Vector3 position)
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

        isSpawnStarted = false;

    }
}
