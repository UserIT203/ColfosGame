using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{
    private CharacterStats myStats;

    public float attackCooldown = 5f;
    private float lastAttackTime;

    public bool attack = false;

    private void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    public void Attack(CharacterStats targetStats)
    {
        if (attack)
        {
            targetStats.TakeDamage(myStats.damage.GetValue());

            lastAttackTime = Time.time;
        }
        attack = false;
    }

    private void Update()
    {
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            attack = true;
        }
    }
}
