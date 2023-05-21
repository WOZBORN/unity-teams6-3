using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Максимальное здоровье игрока
    private int currentHealth; // Текущее здоровье игрока

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Проверка на смерть игрока
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Логика при смерти игрока, например, перезагрузка уровня или отображение экрана поражения
        Debug.Log("Player died.");
    }
}