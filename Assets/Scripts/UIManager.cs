using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoBehaviour, IEnergyHandler
{
    [SerializeField] private TMP_Text _energyTextComponent;


    public void EnergyChanged(int energy)
    {
        _energyTextComponent.text = "Energy: " + energy;
    }

    public void Start()
    {
        var player = FindObjectOfType<Player>();
        EnergyChanged(player.Energy);
    }

}
