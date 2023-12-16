using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    private static List<TurnEntity> _turnList = new List<TurnEntity>();

    public void OnEndTurn()
    {
        _turnList.Clear();
        var entities = FindObjectsOfType<MonoBehaviour>().OfType<TurnEntity>();
        _turnList.AddRange(entities);

        _turnList = _turnList.OrderBy(obj => obj.Priority).ToList();
        foreach (var turn in _turnList)
        {
            turn.TakeTurn();
            Debug.Log($"{turn} took a turn.");
        }
    }

    public void OnStartTurn()
    {

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
