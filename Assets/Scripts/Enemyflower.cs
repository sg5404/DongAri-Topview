using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum flwerEnemyType
{
    sniper,
    rifle,
    shotgun
}

public class Enemyflower : MonoBehaviour
{
    public flwerEnemyType flowertype;

    [SerializeField]
    private int maxBullets;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float createTime = 1.0f;

    public List<GameObject> bulletPool = new List<GameObject>();

    Vector2 targetDir;

    void Start()
    {
        CreateBulletPool();
        InvokeRepeating("CreateBullet", 2.0f, createTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateBullet()
    {

        GameObject _bullet = GetBulletinPool();
        targetDir = (GameManager.GetInstance().Playertransform.position - transform.position);
        //Debug.DrawRay(gameObject.transform.position, targetDir*100, Color.green,10);
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        //print(angle);
        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        //print(angleAxis);
        _bullet?.transform.SetPositionAndRotation(this.gameObject.transform.position, angleAxis);
        _bullet.SetActive(true);
    }

    void CreateBulletPool()
    {
        for (int i = 0; i < maxBullets; ++i)
        {
            var _bullet = Instantiate<GameObject>(bullet);

            _bullet.name = $"Bullet_{i:00}";

            _bullet.SetActive(false);

            bulletPool.Add(_bullet);
        }
    }

    public GameObject GetBulletinPool()
    {
        foreach (var _monster in bulletPool)
        {
            if (_monster.activeSelf == false)
            {
                return _monster;
            }
        }
        return null;
    }
}
