using UnityEngine;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    [SerializeField] private int _energy;
    [SerializeField] private UnityEvent<int> _energyChanged;

    public int Energy => _energy;

    public void SetEnergyAt(int energy)
    {
        _energy = energy;
        _energyChanged.Invoke(energy);
    }


}
