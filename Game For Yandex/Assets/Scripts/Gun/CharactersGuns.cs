using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TypeGun
{
    Fork,
    Headn
}

public enum KindGun
{
    Melee,
    Ranged
}

public class CharactersGuns : MonoBehaviour
{
    public TypeGun typeGun;
    public KindGun kindGun;

}

public class RangedWeapon : CharactersGuns
{
    [Header("Bullet")]
    [SerializeField] int allBullets;
    [SerializeField] int BulletsInGun;
}
