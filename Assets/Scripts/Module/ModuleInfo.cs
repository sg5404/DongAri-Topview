using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Module/Weapon")]
public class ModuleInfo : ScriptableObject
{
    public WeaponKind kind;//��������
    public float atkSpeed;//����

    public float bulletSpread;//ź����
    public int oneShotBullets;//�ѹ��� ������ �Ѿ� ��

    public bool isAutoShot;//����

    public int magazine;//źâ
    public bool isInfiniteBullet;//�ѹ� źâ
    public float reload;//������ �ð�
}
