using UnityEngine;

public class Cactus : TurnEntity
{
    public override void TakeTurn()
    {
    }

    public override void Start()
    {
        base.Start();
        _priority = 10;
    }
}
