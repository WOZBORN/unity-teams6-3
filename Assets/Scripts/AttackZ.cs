using UnityEngine;

public class AttackZ : MonoBehaviour
{
    public int attackDamage = 10; // ���� �� �����
    public float attackCooldown = 1f; // ����� ����� �������

    private bool canAttack = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canAttack)
        {
            // ������ ������ �����, ����� ����� �������� ���� ����������� ������
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(attackDamage);
            }

            canAttack = false;
            Invoke(nameof(ResetAttack), attackCooldown); // �������� ����� ��������� ������
        }
    }

    private void ResetAttack()
    {
        canAttack = true;
    }
}