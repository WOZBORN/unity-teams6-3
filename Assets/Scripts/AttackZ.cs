using UnityEngine;

public class AttackZ : MonoBehaviour
{
    public int attackDamage = 10; // Урон от атаки
    public float attackCooldown = 1f; // Время между атаками

    private bool canAttack = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canAttack)
        {
            // Пример логики атаки, здесь можно вставить вашу собственную логику
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(attackDamage);
            }

            canAttack = false;
            Invoke(nameof(ResetAttack), attackCooldown); // Задержка перед следующей атакой
        }
    }

    private void ResetAttack()
    {
        canAttack = true;
    }
}