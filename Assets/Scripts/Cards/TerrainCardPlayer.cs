using UnityEngine;
[CreateAssetMenu(fileName = "TerrainCardPlayer")]
public class TerrainCardPlayer : CardPlayer
{
    public override void Play(CardPlayEventData eventData)
    {
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
        TerrainCardSO terrainCardSO = eventData.Card.CardInfo as TerrainCardSO;

        if (eventData.Card.CardInfo.PlacementStrategy.CanPlace(eventData))
        {
            eventData.Tilemap.SetTile(tilePosition, terrainCardSO.Tile);

            var player = FindObjectOfType<Player>();

            player.SetEnergyAt(eventData.CurrentEnergy - eventData.Card.CardInfo.Cost);
            Destroy(eventData.Card.gameObject);
        }         
    }
}
