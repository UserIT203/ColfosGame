using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunsPanel : MonoBehaviour
{
    [Header("Another Links")]
    [SerializeField] public PlayerManager playerManager;


    private int idKitGun = 0;
    private int idNextKitGun = 1;


    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        Debug.Log("Take gun 1");
    //        idKitGun = 0;
    //        idNextKitGun = 1;
    //    }else if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        Debug.Log("Take gun 2");
    //        idKitGun = 1;
    //        idNextKitGun = 0;
    //    }

    //    GetGunPanel();
    //}
}
