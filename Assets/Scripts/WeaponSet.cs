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
                SetWeapon(1);
                break;
            case "2":
                SetWeapon(2);
                break;
            case "3":
                SetWeapon(3);
                break;
            case "4":
                SetWeapon(4);
                break;
            case "5":
                SetWeapon(5);
                break;
            default:
                return;
        }
    }
    void SetWeapon(int _keyValue)
    {

    }
}
