using UnityEngine;
using UnityEngine.Events;

public abstract class CardPlayer : ScriptableObject
{
    public abstract void Play(CardPlayEventData eventData);
    
}
