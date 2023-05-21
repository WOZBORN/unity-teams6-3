using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int currentHealth;
    [SerializeField] private HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetBarValue(currentHealth, maxHealth);
    }

    public void GetDamage(int _damage)
    {
        currentHealth -= _damage;
        healthBar.SetBarValue(currentHealth, maxHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
