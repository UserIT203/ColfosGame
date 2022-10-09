using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuns : MonoBehaviour
{
    public List<GameObject> allGuns;

    [HideInInspector]
    public List<GameObject> kitGuns;

    public int idCurrentGun = 0;
    private void Awake()
    {
        CheckGunInHeadn(0);
    }

    public bool CheckGunInPlayer(CharactersGuns charGuns)
    {
        foreach (GameObject gun in allGuns)
        {
            if (gun.GetComponent<Gun>().typeGun == charGuns.typeGun && charGuns.inGround)
            {
                if (gun.active)
                {
                    gun.GetComponent<Gun>().allBullets += charGuns.GetComponent<Gun>().allBullets / 4;

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

    private void CheckGunInHeadn(int idGun)
    {
        Gun currentGun = allGuns[idGun].GetComponent<Gun>();

        if (currentGun.inHeadn)
        {
            Debug.Log("This weapon in headn now");
        }
        else
        {
            idCurrentGun = idGun;
            allGuns[allGuns.Count - idGun - 1].GetComponent<Gun>().inHeadn = false;
            allGuns[allGuns.Count - idGun - 1].SetActive(false);

            currentGun.inHeadn = true;
            allGuns[idGun].SetActive(true);
            Debug.Log("This weapon take in headn. id: " + idGun + " name: " + allGuns[idGun].name);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckGunInHeadn(0);
        }else if (Input.GetKeyDown(KeyCode.Alpha2) && allGuns.Count == 2)
        {
            CheckGunInHeadn(1);
        }
    }
}
