using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] protected int _maxHealth;
    protected int _currentHealth;
    public int CurrentHealth => _currentHealth;

    public virtual void SetHealth(int health)
    {
        _currentHealth = health;
        if (CurrentHealth <= 0)
        {
           Destroy(gameObject);
        }
    }
}
