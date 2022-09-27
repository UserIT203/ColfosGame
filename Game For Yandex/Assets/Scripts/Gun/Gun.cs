using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : CharactersGuns
{
    [HideInInspector] public int allBullets;
    [HideInInspector] public int bulletsInGun;


    private void Awake()
    {
        Debug.Log(allBullets);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            TakeGun(collision.gameObject);
        }
    }

    public void TakeGun(GameObject player)
    {
        PlayerGuns playerGuns = player.GetComponent<PlayerGuns>();

        if (playerGuns.CheckGunInPlayer(this))
        {
            Debug.Log("Is in player");
        }
        else
        {
            if (playerGuns.CountGunsKit() == 2)
            {
                Debug.Log("Change Gun");
            }
            else
            {
                Debug.Log("Get Gun");
            }
        }
    }
}
