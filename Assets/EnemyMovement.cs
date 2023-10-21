using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 100f;

    private bool movingRight = true;

    public Transform groundDetection;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        if (agent.remainingDistance < 0.1f)
        {
            if (movingRight == true)
            {
                agent.SetDestination(transform.position + Vector3.right * distance);
                movingRight = false;
            }
            else
            {
                agent.SetDestination(transform.position + Vector3.left * distance);
                movingRight = true;
            }
        }
    }
}
