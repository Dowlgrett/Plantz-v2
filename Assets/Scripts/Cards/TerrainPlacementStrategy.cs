using UnityEngine;
[CreateAssetMenu(menuName = "TerrainPlacementStrategy")]
public class TerrainPlacementStrategy : PlacementStrategy
{
    public override bool CanPlace(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);

        if (!eventData.Tilemap.HasTile(tilePosition) && eventData.CurrentEnergy >= eventData.Card.CardInfo.Cost && IsAdjacent())
        {
            return true;
        }
        else
        {
            return false;
        }

        bool IsAdjacent()
        {
            var up = new Vector3Int(tilePosition.x, tilePosition.y + 1);
            var down = new Vector3Int(tilePosition.x, tilePosition.y - 1);
            var left = new Vector3Int(tilePosition.x - 1, tilePosition.y);
            var right = new Vector3Int(tilePosition.x + 1, tilePosition.y);

            if(eventData.Tilemap.HasTile(up) || eventData.Tilemap.HasTile(down) || eventData.Tilemap.HasTile(left) || eventData.Tilemap.HasTile(right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
