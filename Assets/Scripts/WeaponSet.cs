using System;
using UnityEngine;
public class WeaponSet : MonoBehaviour
{
   public WeaponSet()
    {
        MainWeaponState = WeaponKind.SWORD;
        SubWeaponState = WeaponKind.RIFLE;
    }
    public enum WeaponKind
    {
        SWORD = 0,
        RIFLE,
        SNIPER,
        SHOTGUN,
        GRANADE
    }
    private WeaponKind mainWeaponState = 0;
    private WeaponKind subWeaponState = 0;
    public WeaponKind MainWeaponState
    {
        get
        {
            return mainWeaponState;
        }
        set
        {
            if (value >= WeaponKind.SWORD && value <= WeaponKind.GRANADE)
            {
                mainWeaponState = value;
            }
        }
    }
    public WeaponKind SubWeaponState
    {
        get
        {
            return subWeaponState;
        }
        set
        {
            if (value >= WeaponKind.SWORD && value <= WeaponKind.GRANADE)
            {
                subWeaponState = value;
            }
        }
    }
    public WeaponKind SetWeapon(string _input)
    {
        WeaponKind _weaponKind = subWeaponState;

        switch (_input)
        {
            case "1":
                _weaponKind = WeaponKind.SWORD;
                break;
            case "2":
                _weaponKind = WeaponKind.RIFLE;
                break;
            case "3":
                _weaponKind = WeaponKind.SNIPER;
                break;
            case "4":
                _weaponKind = WeaponKind.SHOTGUN;
                break;
            case "5":
                _weaponKind = WeaponKind.GRANADE;
                break;
            default:
                break;
        }
        return _weaponKind;
    }
}
