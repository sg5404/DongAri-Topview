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
public class WeaponSet : MonoBehaviour
{
    private void Update()
    {
        string input = Input.inputString;
        switch (input)
        {
            case "1":
                SetWeapon(WeaponKind.SWORD);
                break;
            case "2":
                SetWeapon(WeaponKind.RIFLE);
                break;
            case "3":
                SetWeapon(WeaponKind.SNIPER);
                break;
            case "4":
                SetWeapon(WeaponKind.SHOTGUN);
                break;
            case "5":
                SetWeapon(WeaponKind.GRANADE);
                break;
            default:
                return;
        }
    }
    void SetWeapon(WeaponKind WK)
    {
        
    }
}
