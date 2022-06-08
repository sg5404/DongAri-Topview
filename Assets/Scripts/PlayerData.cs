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
        MAXAMMO,
        CRITCHANCE,
        CRITDMG,
        MOVESPEED,
        ATKSPEED,
        GOLD,
        LIFEDRAIN
    }
    private int hp;
    private int maxHp;
    public int HP
    {
        get { return hp; }
        set
        {
            hp = value;
            if (hp <= 0) { isDead = true; }
        }
    }
    public int MaxHp
    {
        get { return maxHp; }
        set
        {
            maxHp = value;
            if (maxHp <= 0) { isDead = true; }
        }
    }
    private int mp;
    private float atk;
<<<<<<< HEAD
    private int def;
=======
    public float ATK
    {
        get { return atk; }
        set { atk = value; }
    }
>>>>>>> caa4f8a0d707dc2a5a80e8020d22edb8f48df420
    private float cooltime;
    private int ammo;
    private int max_ammo;

    private float critical_chance;
    private float critical_dmg;
    private float move_speed;
    private float atk_speed;

    private int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            if (value <= 0)
            {
                buyAble = false;
            }
        }

    }
    private float life_drain;

    private bool isDead = false;
    private bool buyAble = true;

    void SetValue(float _value, DataState _setData)
    {
        switch (_setData)
        {
            case DataState.HP:
                HP = (int)_value;
                break;
            case DataState.ATK:
                atk = _value;
                break;
            case DataState.COOLTIME:
                cooltime = _value;
                break;
            case DataState.AMMO:
                ammo = (int)_value;
                break;
            case DataState.MAXAMMO:
                max_ammo = (int)_value;
                break;
            case DataState.CRITCHANCE:
                critical_chance = _value;
                break;
            case DataState.CRITDMG:
                critical_dmg = _value;
                break;
            case DataState.MOVESPEED:
                move_speed = _value;
                break;
            case DataState.ATKSPEED:
                atk_speed = _value;
                break;
            case DataState.GOLD:
                Gold = (int)_value;
                break;
            case DataState.LIFEDRAIN:
                life_drain = _value;
                break;
        }
    }
}
