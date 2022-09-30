using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MapSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private GameObject _spikePrefab;

    private BoxCollider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        SpawnObjects(_coinPrefab,GameParams.MoneyCount);
        SpawnObjects(_spikePrefab,GameParams.SpikeCount);
    }


    private void SpawnObjects(GameObject objPrefab, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Instantiate(objPrefab, GetRandomPoint(), Quaternion.identity);
        }
    }

    private Vector2 GetRandomPoint()
    {
        float minX = _collider.bounds.min.x;
        float minY = _collider.bounds.min.y;
        float maxX = _collider.bounds.max.x;
        float maxY = _collider.bounds.max.y;

        return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }
}
