using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;


public abstract class CardPlayer : ScriptableObject
{
    public abstract void Play(CardPlayEventData eventData);
    
}
