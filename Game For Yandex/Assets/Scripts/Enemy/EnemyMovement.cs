using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    NavMeshAgent agent;

    private void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
