using UnityEngine;
[CreateAssetMenu(menuName = "PlantPlacementStrategy")]
public class PlantPlacementStrategy : PlacementStrategy
{
    public override bool CanPlace(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
        var center = eventData.Tilemap.GetCellCenterWorld(tilePosition);

        if (Physics2D.OverlapPoint(center) == null &&
            eventData.Tilemap.GetTile(tilePosition) != null &&
            eventData.CurrentEnergy >= eventData.Card.CardInfo.Cost)
        {
            return true;
        }     
        else
        {
            return false;
        }
    }
}
