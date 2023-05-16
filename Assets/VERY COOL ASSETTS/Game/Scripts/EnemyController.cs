using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform Target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //GameObject[] gameObjects;
        //gameObjects = GameObject.FindGameObjectsWithTag("Player");
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
        agent.destination = Target.position;
    }
}