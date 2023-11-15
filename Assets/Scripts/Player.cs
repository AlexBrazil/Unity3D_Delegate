using UnityEngine;
using UnityEngine.EventSystems;

public delegate void HealthChanged(float currentHealth);

public class Player : MonoBehaviour, IPointerClickHandler
{
    public event HealthChanged onHealthChanged;
    public int health = 100;

    public void OnPointerClick(PointerEventData eventData)
    {
        TakeDamage(5);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            onHealthChanged?.Invoke(health);
        }
    }
}
