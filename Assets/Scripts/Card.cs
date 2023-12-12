using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Card : MonoBehaviour
{
    public MonoScript ActionScript;
    public int Cost;
    public Sprite Sprite;

    public abstract bool CanPlay(CardPlayEventData eventData);
}
