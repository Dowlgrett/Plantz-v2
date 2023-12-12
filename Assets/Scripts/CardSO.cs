using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "CardSO")]
public class CardSO : ScriptableObject
{
    public Sprite Sprite;
    public MonoScript ActionScript; //could be null if the card is non-Plant;
    public string Title;
    public string Description;
    public int Cost;
}
