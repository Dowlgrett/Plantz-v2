using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GroundTileGenerator : MonoBehaviour
{
    [SerializeField] public Tilemap tilemap;
    [SerializeField] public TileBase tile;

    void Start()
    {
        tilemap.SetTile(new Vector3Int(0, 0, 0), tile);

        var center = FindObjectOfType<CenterCameraOnTilemap>();
        center.CenterCamera();

    }


}
