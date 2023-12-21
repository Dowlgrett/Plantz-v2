using TurnSystem;
public class Sunflower : TurnEntity
{
    public override void TakeTurn()
    {
        var player = FindObjectOfType<Player>();
        player.SetEnergyAt(player.Energy + 1);
    }

    protected override void Start()
    {
        base.Start();
        _priority = 100;
    }
}
