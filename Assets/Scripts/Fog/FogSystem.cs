using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FogSystem : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;

    public void UpdateFog()
    {
        var foggables = FindObjectsOfType<Foggable>();

        foreach (var foggable in foggables)
        {
            var isVisible = foggable.IsVisible();

            foggable.GetComponent<SpriteRenderer>().enabled = isVisible;

        }
    }
}