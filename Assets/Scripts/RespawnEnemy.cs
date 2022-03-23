using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetvenSpawn;

    private float _elapserTime = 0;

    private void Update()
    {
        _elapserTime += Time.deltaTime;

        if(_elapserTime >= _secondsBetvenSpawn)
        {
            _elapserTime = 0;
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[spawnPointNumber]);
        }
    }
}
