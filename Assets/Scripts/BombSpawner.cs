using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private Bomb _bomb;
    [SerializeField] private float _posRange;
    [SerializeField] private float _spawnRateDecreaseRate = 5;
    [SerializeField] private float _spawnRateDecreaseFactor = 0.05f;
    private float _spawnRate = 1f;
    private float _timeSinceLastSpawn = 0;

    private void Start()
    {
        InvokeRepeating("DecreaseSpawnRate", 0, _spawnRateDecreaseRate);
    }

    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;

        if (_timeSinceLastSpawn >= _spawnRate)
        {
            _timeSinceLastSpawn = 0;
            Instantiate(_bomb, new Vector2(transform.position.x + Random.Range(-_posRange, _posRange), transform.position.y), Quaternion.identity);
        }
    }

    private void DecreaseSpawnRate()
    {
        _spawnRate -= _spawnRateDecreaseFactor;
    }
}
