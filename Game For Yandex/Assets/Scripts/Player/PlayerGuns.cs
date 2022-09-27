using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuns : MonoBehaviour
{
    public GameObject[] allGuns;

    [HideInInspector]
    public List<GameObject> kitGuns;

    private void Awake()
    {
        CountGunsKit();
    }

    public bool CheckGunInPlayer(CharactersGuns charGuns)
    {
        foreach (GameObject gun in allGuns)
        {
            if (gun.GetComponent<Gun>().typeGun == charGuns.typeGun)
            {
                if (gun.active)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        return false;
    }

    public int CountGunsKit()
    {
        int countKitGun = 0;

        foreach (GameObject gun in allGuns)
        {
            if (gun.active)
            {
                kitGuns.Add(gun);
                countKitGun += 1;
            }
        }

        return countKitGun;
    }
}
