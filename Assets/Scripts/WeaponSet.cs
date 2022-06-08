using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponKind
{
    SWORD = 0,
    RIFLE,
    SNIPER,
    SHOTGUN,
    GRANADE
}
public class WeaponSet
{
    WeaponKind mainWeaponState = 0;
    WeaponKind subWeaponState;
    void SetWeapon(string _input)
    {
        switch (_input)
        {
            case "1":
                subWeaponState = WeaponKind.SWORD;
                break;
            case "2":
                subWeaponState = WeaponKind.RIFLE;
                break;
            case "3":
                subWeaponState = WeaponKind.SNIPER;
                break;
            case "4":
                subWeaponState = WeaponKind.SHOTGUN;
                break;
            case "5":
                subWeaponState = WeaponKind.GRANADE;
                break;
            default:
                return;
        }
    }
}
