using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : CharactersGuns
{
    [Header("Player Links")]
    [SerializeField] private GameObject playerGunBox;

    [Header("Optins")]
    [SerializeField] private float rotateSpeed;

    [HideInInspector] public int allBullets;
    [HideInInspector] public int bulletsInGun;


    private void Awake()
    {
        CheckInGround();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && inGround)
        {
            TakeGun(other.gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.transform.tag == "Player" && inGround)
    //    {
    //        TakeGun(collision.gameObject);
    //    }
    //}

    private void CheckInGround()
    {
        if (transform.parent == null)
            inGround = true;
        else
            inGround = false;
    }

    public void TakeGun(GameObject player)
    {
        PlayerGuns playerGuns = player.GetComponent<PlayerGuns>();
        Transform playerTransform = player.transform;

        if (playerGuns.CheckGunInPlayer(this))
        { 
            Debug.Log(gameObject.name);

            Destroy(gameObject);
        }
        else
        {
            if (playerGuns.allGuns.Count == 2)
            {
                Debug.Log("Change Gun");
            }
            else
            {
                inGround = false;

                transform.SetParent(playerGunBox.transform);
                transform.position = new Vector3(playerTransform.position.x,
                    playerTransform.position.y, playerTransform.position.z);

                playerGuns.allGuns.Add(this.gameObject);
            }
        }
    }

    private void Update()
    {
        if (inGround)
        {
            transform.Rotate(new Vector3(0, 45, 0) * rotateSpeed * Time.deltaTime);
        }
    }
}
