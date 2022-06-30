using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBase : MonoBehaviour, CharBase
{
    [SerializeField]
    private PlayerModule _playerModule;

    #region 캐릭터 기본 수치
    private int _hp;
    public int Hp
    {
        get => _hp;
        set { _hp = Mathf.Clamp(value, 0, _playerModule.HP); }
    }

    private float _def;
    public float Def
    {
        get => _def;
        set { _def = (value + _playerModule.def); }
    }

    private float _moveSpeed;
    public float MoveSpeed
    {
        get => _moveSpeed;
        set { _moveSpeed = (value + _playerModule.moveSpeed); }
    }

    private bool[] _statusAilments;
    public bool[] this[int i]
    {
        get => _statusAilments;
        set { _statusAilments = value; }
    }

    private bool _canAilments;
    public bool CanAilments
    {
        get => _canAilments;
        set { _canAilments = value; }
    }

    private bool _isEnemy=false;
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

    [field: SerializeField] public UnityEvent OnDie { get; set; }
    [field: SerializeField] public UnityEvent OnGetHit { get; set; }

    public void Hit(int damage, GameObject damageDealer, StatusAilments status, float chance)
    {
        Debug.Log("플레이어가 얻어맞았습니다.");
    }
}
