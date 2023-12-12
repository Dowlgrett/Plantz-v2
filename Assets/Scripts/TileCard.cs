using UnityEngine;

public class TileCard : Card
{
    public override bool CanPlay(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);

        if (eventData.Tilemap.HasTile(tilePosition))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
