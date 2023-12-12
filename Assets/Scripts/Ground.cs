using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Ground : MonoBehaviour, IAction
{
    [SerializeField] private TileBase _tile;

    private void Awake()
    {
        _tile = AssetDatabase.LoadAssetAtPath<TileBase>("Assets/Scripts/Scriptable Objects/Custom Ground Tile.asset");
    }


    public void Play(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);

        eventData.Tilemap.SetTile(tilePosition, _tile);
        Destroy(gameObject);
    }
}
