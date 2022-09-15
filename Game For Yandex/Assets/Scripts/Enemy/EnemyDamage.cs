using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerManager playerManager;

    [Header("Main Character")]
    public float attackCooldown = 5f;

    private EnemyMovement enemyMovement;
    private Animator animator;

    private EnemyStats enemyStats;

    private float lastTimeAttack = 0;

    public bool readyToAttack;
    public bool isAttack = false;

    private void Awake()
    {
        enemyMovement = GetComponent<EnemyMovement>();
        animator = GetComponent<Animator>();

        enemyStats = GetComponent<EnemyStats>();
    }

    public void PlayAttackAnimation()
    {
        if (readyToAttack)
        {
            animator.SetTrigger("isAttack");

            isAttack = true;
        }
    }

    public void StopAttackAnimation()
    {
        animator.ResetTrigger("isAttack");
        isAttack = false;
    }

    public void OnAttack()
    {

        if (isAttack && enemyMovement.aroundPlayer)
        {
            playerManager.player.GetComponent<CharacterStats>().TakeDamage(enemyStats.damage.GetValue());
            playerManager.player.GetComponent<PlayerHealth>().AddHealthText();
        }

        lastTimeAttack = Time.time;
    }

    private void Update()
    {
        if (Time.time - lastTimeAttack >= attackCooldown)
        {
            readyToAttack = true;
        }
        else
        {
            readyToAttack = false;
        }
    }

}