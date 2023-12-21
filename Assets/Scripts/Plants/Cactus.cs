using TurnSystem;
using UnityEngine;

public class Cactus : TurnEntity
{
    public override void TakeTurn()
    {
    }

    protected override void Start()
    {
        base.Start();
        _priority = 10;
    }
}
