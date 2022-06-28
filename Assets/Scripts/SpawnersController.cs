using System.Collections;
using UnityEngine;

public class SpawnersController : MonoBehaviour
{
    [SerializeField] private float _spawnerStartDelay;

    private EnemySpawner[] _enemySpawners;

    private void Awake()
    {
        _enemySpawners = GetComponentsInChildren<EnemySpawner>();
    }

    private void Start()
    {
        StartCoroutine(SpawnCoroutine(_spawnerStartDelay));
    }

    private IEnumerator SpawnCoroutine(float delay)
    {
        foreach (EnemySpawner spawner in _enemySpawners)
        {
            spawner.StartInstantSpawn(_enemySpawners.Length * delay);
            yield return new WaitForSeconds(delay);
        }
    }
}