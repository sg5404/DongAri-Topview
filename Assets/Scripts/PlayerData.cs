using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : WeaponSet
{
    enum DataState
    {
        HP,
        MP,
        ATK,
        COOLTIME,
        AMMO,
        MAX_AMMO,
        CRITCHANCE,
        CRITDMG,
        MOVESPEED,
        ATKSPEED,
        GOLD,
        LIFEDRAIN
    }
    private int hp;
    public int HP
    {
        get { return hp; }
        set
        {
            hp = value;
            if (hp <= 0) { isDead = true; }
        }
    }
    private int mp;
    public int MP
    {
        get { return mp; }
        set { mp = value; }
    }
    private float atk;
    public float ATK
    {
        get { return mp; }
        set { mp = value; }
    }
    private float cooltime;

    private int ammo;
    private int max_ammo;

    private float critical_chance;
    private float critical_dmg;
    private float move_speed;
    private float atk_speed;

    private int gold;
    private int life_drain;

    private bool isDead;
}
