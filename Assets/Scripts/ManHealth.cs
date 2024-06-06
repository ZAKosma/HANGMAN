using UnityEngine;

public class ManHealth : MonoBehaviour
{
    public int health = 5;
    public delegate void HealthChanged(int health);
    public event HealthChanged OnHealthChanged;

    public int InitializeHealth()
    {
        health = 5;
        OnHealthChanged?.Invoke(health);
        return health;
    }

    public int DecrementHealth()
    {
        health--;
        OnHealthChanged?.Invoke(health);
        return health;
    }

    public bool IsDead()
    {
        return health <= 0;
    }
}