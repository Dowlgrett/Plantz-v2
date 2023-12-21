using CardSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class CardPlayOnDragHandler : MonoBehaviour, IEndDragHandler
{
    public UnityEvent CardWasPlayed;

    public void Start()
    {
        CardWasPlayed.AddListener(FindObjectOfType<FogSystem>().UpdateFog);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var plantingEventData = new CardPlayEventData(EventSystem.current);
        var player = FindObjectOfType<Player>();
        plantingEventData.Tilemap = FindObjectOfType<Tilemap>();
        plantingEventData.position = eventData.position;
        plantingEventData.CurrentEnergy = player.Energy;

        if (eventData.pointerDrag.TryGetComponent(out Card card))
        {
            plantingEventData.Card = card;
            plantingEventData.Card.CardInfo.CardPlayer.Play(plantingEventData);
            CardWasPlayed?.Invoke();
        }
    }
}
