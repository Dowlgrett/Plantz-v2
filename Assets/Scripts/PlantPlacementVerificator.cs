using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class PlantPlacementVerificator : MonoBehaviour
{
    public static bool CanPlant(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
        var center = eventData.Tilemap.GetCellCenterWorld(tilePosition);

        if (Physics2D.OverlapPoint(center) == null &&
            eventData.Tilemap.GetTile(tilePosition) != null &&
            eventData.CurrentEnergy >= eventData.Card.Cost)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
}
