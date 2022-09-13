using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable
{
    PlayerManager playerManager;

    CharacterStats myStats;
    CharacterCombat myCombat;

    EnemyMovement enemyMovement;

    private void Start()
    {
        playerManager = PlayerManager.instance;

        myStats = GetComponent<CharacterStats>();
        myCombat = GetComponent<CharacterCombat>();

        enemyMovement = GetComponent<EnemyMovement>();
    }

    public void OnAttack()
    {
        CharacterStats playerStats = playerManager.player.GetComponent<CharacterStats>();
        if (myCombat != null && enemyMovement.aroundPlayer)
        {
            myCombat.Attack(playerStats);
        }
    }
}
