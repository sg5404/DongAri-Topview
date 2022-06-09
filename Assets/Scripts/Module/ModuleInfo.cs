using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Module")]
public class ModuleInfo : ScriptableObject
{
    public WeaponKind kind;//무기종류
    public int atk;//공격력
    public float atkSpeed;//공속
    public float minDmg;//최소데미지(거리비례)

    public float bulletSpread;//탄퍼짐
    public int oneShotBullets;//한번에 나가는 총알 수
    public float range;//사거리

    public float crtDmg;//치뎀
    public float crtChance;//치확

    public bool isAutoShot;//연사
    public bool isExplosion;//광역
    public float explosionRange;//광역범위
    public bool isKnockBack;//넉백
    public float knockBackRange;//넉백범위
    public bool isPenetrate;//관통

    public int magazine;//탄창
    public bool isInfiniteBullet;//한무 탄창
    public float reload;//재장전 시간
}
