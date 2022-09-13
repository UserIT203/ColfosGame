using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Animator animator;

    private Transform target;
    NavMeshAgent agent;

    public bool aroundPlayer { get; private set; }

    private void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f); 
    }

    private void Update()
    {
        agent.SetDestination(target.position);


        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= agent.stoppingDistance + 1)
        {
            aroundPlayer = true;

            animator.SetTrigger("isAttack");
            FaceTarget();
        }
        else
            aroundPlayer = false;

        animator.SetBool("aroundPlayer", aroundPlayer);
    }

}
