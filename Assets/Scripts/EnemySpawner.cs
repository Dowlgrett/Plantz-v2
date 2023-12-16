using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    private void Start()
    {
        var tilemap = FindObjectOfType<Tilemap>();
        var centerPosition = tilemap.GetCellCenterWorld(new Vector3Int(0, 3));
        Instantiate(_enemyPrefab, centerPosition, Quaternion.identity);
    }
}
