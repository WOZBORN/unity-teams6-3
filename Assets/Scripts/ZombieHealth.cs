using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int maxHealth = 100; // Максимальное здоровье зомби
    private int currentHealth; // Текущее здоровье зомби

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Проверка на смерть зомби
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Логика при смерти зомби, например, удаление объекта или воспроизведение анимации смерти
        Destroy(gameObject);
    }
}
