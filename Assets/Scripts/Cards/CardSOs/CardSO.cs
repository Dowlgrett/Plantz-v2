using UnityEngine;

public class CardSO : ScriptableObject
{
    public Sprite CardSprite;
    public PlacementStrategy PlacementStrategy;
    public CardPlayer CardPlayer;
    public string Title;
    public string Description;
    public int Cost;
    public int MaxHealth;
}

