using TurnSystem;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : TurnEntity
{
    private int _damage = 3;
    
    public override void TakeTurn()
    {
        var target = GetAdjacentTarget();
        if (target != null)
        {
            Attack(target);
        }
        else
        {
            MakeRandomMove();
        }
    }

    private void MakeRandomMove()
    {
        Vector3Int[] positions = { Vector3Int.up, Vector3Int.down, Vector3Int.left, Vector3Int.right};

        transform.position += positions[Random.Range(0, positions.Length)];
    }

    private void Attack(Health target)
    {
        target.SetHealth(target.CurrentHealth - _damage);
    }

    private Health GetAdjacentTarget()
    {
         Vector3Int[] positions = {Vector3Int.up, Vector3Int.down, Vector3Int.left, Vector3Int.right};


        var tilemap = FindObjectOfType<Tilemap>();
        foreach (var position in positions)
        {
            var checkPosition = tilemap.WorldToCell(transform.position) + position;
            var target = tilemap.GetInstantiatedObject(checkPosition);
            if (target != null)
            {
                var plant = Physics2D.OverlapPoint(tilemap.GetCellCenterWorld(checkPosition));
                if (plant != null)
                {
                    return plant.GetComponent<Health>();
                }
                else return target.GetComponent<Health>();
            }              
        } 
        return null;
    }

    protected override void Start()
    {
        base.Start();
        _priority = 50;
    }

}
