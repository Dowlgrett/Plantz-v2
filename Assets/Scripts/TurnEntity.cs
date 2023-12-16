using UnityEngine;

public abstract class TurnEntity : MonoBehaviour
{
    public abstract void TakeTurn();
    public int Priority => _priority;
    protected int _priority;
    protected virtual void Start()
    {
        TurnController.AddToTurnList(this);
    } 
}
