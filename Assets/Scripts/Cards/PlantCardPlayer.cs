using UnityEngine;
[CreateAssetMenu(fileName = "PlantCardPlayer")]
public class PlantCardPlayer : CardPlayer
{
    [SerializeField] private GameObject _plantPrefab;
    public override void Play(CardPlayEventData eventData)
    {
        if (eventData.Card.CardInfo.PlacementStrategy.CanPlace(eventData))
        {
            var PlantCardSO = eventData.Card.CardInfo as PlantCardSO;

            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(eventData.position);
            var tilePosition = eventData.Tilemap.WorldToCell(mouseWorldPosition);
            var centerPosition = eventData.Tilemap.GetCellCenterWorld(tilePosition);

            var plantObject = Instantiate(_plantPrefab, centerPosition, Quaternion.identity);
            plantObject.AddComponent(PlantCardSO.PlantScript.GetClass());
            plantObject.GetComponent<SpriteRenderer>().sprite = PlantCardSO.PlantSprite;

            var player = FindObjectOfType<Player>();

            player.SetEnergyAt(eventData.CurrentEnergy - eventData.Card.CardInfo.Cost);
            Destroy(eventData.Card.gameObject);
        }
    }
}