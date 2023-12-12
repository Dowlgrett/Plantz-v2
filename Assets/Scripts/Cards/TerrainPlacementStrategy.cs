using UnityEngine;
[CreateAssetMenu(menuName = "TerrainPlacementStrategy")]
public class TerrainPlacementStrategy : PlacementStrategy
{
    public override bool CanPlace(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);

        if (eventData.Tilemap.HasTile(tilePosition) || eventData.CurrentEnergy < eventData.Card.CardInfo.Cost)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
