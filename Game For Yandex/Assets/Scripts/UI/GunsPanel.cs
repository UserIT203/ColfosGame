using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunsPanel : MonoBehaviour
{
    [Header("Another Links")]
    [SerializeField] public PlayerManager playerManager;
    private PlayerGuns playerGuns;

    private int idKitGun = 0;

    [Header("UI Links")]
    [SerializeField] private Text allBulletsInGun;
    [SerializeField] private Text currentBulletsInGun;

    private void Awake()
    {
        playerGuns = playerManager.player.GetComponent<PlayerGuns>();
        GetGunPanel();
    }

    private void GetGunPanel()
   {

        GameObject currentGun = playerGuns.allGuns[idKitGun];

        if (currentGun.GetComponent<Gun>().kindGun == KindGun.Ranged)
        {
            allBulletsInGun.text = System.Convert.ToString(currentGun.GetComponent<Gun>().allBullets);
            currentBulletsInGun.text = System.Convert.ToString(currentGun.GetComponent<Gun>().bulletsInGun);
        }
        else
        {
            allBulletsInGun.text = "0";
            currentBulletsInGun.text = "0";
        }
    }

    private void Update()
    {
        idKitGun = playerGuns.idCurrentGun;
        GetGunPanel();
    }
}
