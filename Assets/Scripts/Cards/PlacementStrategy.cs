using UnityEngine;

public abstract class PlacementStrategy : ScriptableObject
{
    public abstract bool CanPlace(CardPlayEventData eventData);
}
