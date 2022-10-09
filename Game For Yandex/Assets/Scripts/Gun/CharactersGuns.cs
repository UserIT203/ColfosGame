using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TypeGun
{
    Fork,
    Headn,
    Pistol
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

    public bool inHeadn = false;
    public bool inGround;
}
