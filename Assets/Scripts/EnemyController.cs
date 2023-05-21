using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform Target;
    public Animator animator;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Vector3.Distance(transform.position, Target.position) <= 50)
        {
            agent.destination = Target.position;
            if (Vector3.Distance(transform.position, Target.position) <= 2)
            {
                animator.SetBool("IsAttaking", true);
            }
            else
            {
                animator.SetBool("IsAttaking", false);
            }
        }
    }
}