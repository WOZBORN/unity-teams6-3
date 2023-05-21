using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public Transform target; // Цель, к которой зомби будет двигаться

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Установка цели для зомби
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}