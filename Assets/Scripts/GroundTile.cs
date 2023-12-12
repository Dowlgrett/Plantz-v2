using PlasticGui.WorkspaceWindow.PendingChanges.Changelists;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu]
public class GroundTile : TileBase
{
    public Sprite sprite;
    public GameObject GroundTileObject;

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        tileData.sprite = sprite;
        tileData.gameObject = GroundTileObject;
    }
}
