using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBase : MonoBehaviour, CharBase
{
    [SerializeField]
    private EnemyModule _enemyModule;

    #region ĳ���� �⺻ ��ġ
    public int _hp;
    public int Hp
    {
        get => _hp;
        set { _hp = Mathf.Clamp(value, 0, _enemyModule.maxHp); }
    }

    private float _def;
    public float Def
    {
        get => _def;
        set { _def = (value + _enemyModule.def); }
    }

    private float _moveSpeed;
    public float MoveSpeed
    {
        get => _moveSpeed;
        set { _moveSpeed = (value + _enemyModule.moveSpeed); }
    }

    private bool _canAilments;
    public bool CanAilments
    {
        get => _canAilments;
        set { _canAilments = value; }
    }

    public bool _isEnemy = true;
    public bool IsEnemy
    {
        get => _isEnemy;
        set { _isEnemy = value; }
    }

    private bool _isDead;
    public bool IsDead
    {
        get => _isDead;
        set { _isDead = value; }
    }
    #endregion
    #region �� ��ġ
    public bool[] statusAilment = new bool[4];
    protected float stunDuration;
    protected float slowDuration;
    protected float burnDuration;
    #endregion

    [field:SerializeField] public UnityEvent OnDie { get; set; }
    [field:SerializeField] public UnityEvent OnGetHit { get; set; }

    private void Update()
    {
        DurationChange();
    }

    public virtual void Hit(int damage, GameObject damageDealer, StatusAilments status, float chance)
    {
        if (IsDead) return;
        Hp -= damage;
        OnGetHit?.Invoke();
        statusAilment[(int)status] = true;
        if (Hp <= 0)
        {
            OnDie?.Invoke();
            Debug.Log($"{gameObject.name}�� �׾����̴�");
            IsDead = true;
        }
    }

    public void Stun(float stunTime)
    {
        if (stunDuration <= stunTime)
            stunDuration = stunTime;
        statusAilment[(int)StatusAilments.Stun] = true;
        Debug.Log("���� ����");
    }

    private void DurationChange()
    {
        stunDuration -= Time.deltaTime;
        slowDuration -= Time.deltaTime;
        burnDuration -= Time.deltaTime;
        if (stunDuration < 0)
        {
            stunDuration = 0;
            statusAilment[(int)StatusAilments.Stun] = false;
        }
        if (slowDuration < 0)
        {
            slowDuration = 0;
            statusAilment[(int)StatusAilments.Slow] = false;
        }
        if (burnDuration < 0)
        {
            burnDuration = 0;
            statusAilment[(int)StatusAilments.Burn] = false;
        }
    }
}
