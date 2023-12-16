using UnityEngine.Tilemaps;

public class TerrainHealth : Health
{
    public override void SetHealth(int health)
    {
        _currentHealth = health;
        if (CurrentHealth <= 0)
        {
            var tilemap = FindObjectOfType<Tilemap>();
            var tilePosition = tilemap.WorldToCell(transform.position);
            tilemap.SetTile(tilePosition, null);
        }
    }
}
