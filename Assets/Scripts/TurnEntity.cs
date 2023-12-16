using UnityEngine;

public abstract class TurnEntity : MonoBehaviour
{
    public abstract void TakeTurn();
    public int Priority => _priority;
    protected int _priority;
    public virtual void Start()
    {
        TurnController.AddToTurnList(this);
    } 
}
