using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    private static List<TurnEntity> _turnList = new List<TurnEntity>();

    public static void OnEndTurn()
    {
        _turnList.Clear();
        var entities = FindObjectsOfType<TurnEntity>();
        _turnList.AddRange(entities); 

        _turnList.Sort((x, y) => x.Priority.CompareTo(y.Priority));
        foreach (var turn in _turnList)
        {
            turn.TakeTurn();
            Debug.Log($"{turn} took a turn.");
        }
    }

    public static void RemoveFromTurnList(TurnEntity entity)
    {
        _turnList.Remove(entity);
    }

    public static void AddToTurnList(TurnEntity entity)
    {
        _turnList.Add(entity);
    }

}
