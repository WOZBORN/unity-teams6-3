using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int maxHealth = 100; // ������������ �������� �����
    private int currentHealth; // ������� �������� �����

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // �������� �� ������ �����
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // ������ ��� ������ �����, ��������, �������� ������� ��� ��������������� �������� ������
        Destroy(gameObject);
    }
}
