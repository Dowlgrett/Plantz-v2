using UnityEngine;

public class PlantCard : Card
{
    public override bool CanPlay(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
        var center = eventData.Tilemap.GetCellCenterWorld(tilePosition);

        if (Physics2D.OverlapPoint(center) == null &&
            eventData.Tilemap.GetTile(tilePosition) != null &&
            PlantPlacementVerificator.CanPlant(eventData))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
