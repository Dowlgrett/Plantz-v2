using UnityEngine;

public abstract class Plant : MonoBehaviour
{
    public CardPlayEventData eventData;

    public void InitializePosition(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
        var worldTileCenterPosition = eventData.Tilemap.GetCellCenterWorld(tilePosition);

        transform.position = new Vector3(worldTileCenterPosition.x, worldTileCenterPosition.y, 0);
    }
}
