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
        }
    }
    private int mp;
    private float atk;
    private int def;
    public float ATK
    {
        get { return atk; }
        set { atk = value; }
    }
    private float cooltime;
    private int ammo;
    private int max_ammo;

    private float critical_chance;
    private float critical_dmg;
    private float move_speed;
    private float atk_speed;

    public float Atk_Speed
    {
        get { return atk_speed; }
        set
        {
            atk_speed = value;
            if(value <= 0)
            {
                atk_speed = 0;
            }
        }
    }

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
