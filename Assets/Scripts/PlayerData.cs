    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : WeaponSet
{
    int hp;
    int mp;
    float atk;
    float cooltime;

    int ammo;
    int max_ammo;

    float critical_chance;
    float critical_dmg;
    float move_speed;
    float atk_speed;

    int gold;
    int life_drain;

    WeaponKind mainWeaponState = WeaponKind.SWORD;
    WeaponKind subWeaponState = WeaponKind.RIFLE;
}
