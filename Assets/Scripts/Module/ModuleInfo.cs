using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/Module")]
public class ModuleInfo : ScriptableObject
{
    public WeaponKind kind;//��������
    public int atk;//���ݷ�
    public float atkSpeed;//����
    public float minDmg;//�ּҵ�����(�Ÿ����)

    public float bulletSpread;//ź����
    public int oneShotBullets;//�ѹ��� ������ �Ѿ� ��
    public float range;//��Ÿ�

    public float crtDmg;//ġ��
    public float crtChance;//ġȮ

    public bool isAutoShot;//����
    public bool isExplosion;//����
    public float explosionRange;//��������
    public bool isKnockBack;//�˹�
    public float knockBackRange;//�˹����
    public bool isPenetrate;//����

    public int magazine;//źâ
    public bool isInfiniteBullet;//�ѹ� źâ
    public float reload;//������ �ð�
}
