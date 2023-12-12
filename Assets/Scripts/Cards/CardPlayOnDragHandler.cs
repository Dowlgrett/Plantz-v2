using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class CardPlayOnDragHandler : MonoBehaviour, IEndDragHandler
{
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
        }
    }
}
