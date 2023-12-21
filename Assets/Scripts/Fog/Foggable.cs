using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Foggable : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;

    private void Start()
    {
        _tilemap = FindObjectOfType<Tilemap>();
        GetComponent<SpriteRenderer>().enabled = IsVisible();

    }

    private List<Vector3Int> _positionsToCheck = new List<Vector3Int>()
    {
        new Vector3Int(0, 1, 0),
        new Vector3Int(1, 0, 0),
        new Vector3Int(0, -1, 0),
        new Vector3Int(-1, 0, 0),
        new Vector3Int(-1, -1, 0),
        new Vector3Int(1, 1, 0),
        new Vector3Int(1, -1, 0),
        new Vector3Int(-1, 1, 0),
    };

    public bool IsVisible()
    {
        foreach (var position in _tilemap.cellBounds.allPositionsWithin)
        {
            if (_tilemap.HasTile(position))
            {
                foreach (var positionToCheck in _positionsToCheck)
                {
                    Debug.Log($"transform: {_tilemap.WorldToCell(transform.position)}");
                    Debug.Log($"checking pos: {_tilemap.WorldToCell(transform.position) + positionToCheck}");
                    if (_tilemap.WorldToCell(transform.position) == position + positionToCheck)
                    {
                        
                        return true;
                    }
                }
            }
        }
        return false;
    }


}
