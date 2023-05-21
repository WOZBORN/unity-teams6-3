using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public Transform target; // ����, � ������� ����� ����� ���������

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // ��������� ���� ��� �����
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}