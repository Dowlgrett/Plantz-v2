using CardSystem;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

public class CardPlayEventData : PointerEventData
{
    public Tilemap Tilemap;
    public Card Card;
    public int CurrentEnergy;
    public CardPlayEventData(EventSystem eventSystem) : base(eventSystem) { }
}
