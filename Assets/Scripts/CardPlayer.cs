using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;


public class CardPlayer : MonoBehaviour, IEndDragHandler
{
    [SerializeField] private GameObject _actionPrefab;

    public void TryPlaying(CardPlayEventData eventData)
    {
        if (eventData.Card.CanPlay(eventData))
        {
            var action = Instantiate(_actionPrefab, Vector3.zero, Quaternion.identity);
            action.AddComponent(eventData.Card.ActionScript.GetClass());
            if (action.TryGetComponent(out Plant plant))
            {
                plant.InitializePosition(eventData);
            }
            else if (action.TryGetComponent(out IAction act)) {
                
                act.Play(eventData);
            }

            action.GetComponent<SpriteRenderer>().sprite = eventData.Card.Sprite;

            var player = FindObjectOfType<Player>();

            player.SetEnergyAt(eventData.CurrentEnergy - eventData.Card.Cost);
            Destroy(eventData.Card.gameObject);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var plantingEventData = new CardPlayEventData(EventSystem.current);
        var player = FindObjectOfType<Player>();
        plantingEventData.Tilemap = FindObjectOfType<Tilemap>();
        plantingEventData.position = eventData.position;
        plantingEventData.CurrentEnergy = player.Energy;

        if (eventData.pointerDrag.TryGetComponent(out Card plantCard))
        {
            plantingEventData.Card = plantCard;
            TryPlaying(plantingEventData);
        }
    }
}
