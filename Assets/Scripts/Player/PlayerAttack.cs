using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private WeaponSet weaponSet = null;

    [Header("ÃÑ¾Ë")]
    [SerializeField]
    private GameObject rifleBullet = null;
    [SerializeField]
    private GameObject sniperBullet = null;
    [SerializeField]
    private GameObject shotgunBullet = null;
    [SerializeField]
    private GameObject granadeBullet = null;

    [SerializeField]
    private Transform bulletTransform = null;
    [SerializeField]
    private GameObject gunpoint = null;

    [SerializeField]
    private ModuleInfo[] module;
    [SerializeField]
    private int weapon = 1;

    private float cooltime = 0.1f;
    private float curtime = 0;

    void Start()
    {
        weaponSet = GetComponent<WeaponSet>();
    }

    void Update()
    {
        curtime += Time.deltaTime;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        var direction = mousePosition - bulletTransform.position;

        var rotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        bulletTransform.rotation = Quaternion.Euler(0, 0, rotation);
        gunpoint.transform.rotation = Quaternion.Euler(0, 0, rotation);
        CurrentWeapon();
    }

    void CurrentWeapon()
    {
        switch (weaponSet.SubWeaponState) // ÃÑ¾Ë¹ß»ç °¡´ÉÇÏ°Ô²û ÇÏ±â
        {
            case WeaponKind.SWORD:
                weapon = 0;
                break;
            case WeaponKind.RIFLE:
                weapon = 1;
                Fire();
                break;
            case WeaponKind.SNIPER:
                weapon = 2;
                Fire();
                break;
            case WeaponKind.SHOTGUN:
                weapon = 3;
                ShotGunFire();
                break;
            case WeaponKind.GRANADE:
                weapon = 4;
                Fire();
                break;
        }
    }

    void Fire()
    {
        if (Input.GetMouseButton(0))
        {
            if(curtime >= module[weapon].atkSpeed)
            {
                GameObject bullet = Instantiate(rifleBullet, bulletTransform);
                bullet.transform.SetParent(null);
                curtime = 0;
            }

        }

    }

    void ShotGunFire()
    {
        if (Input.GetMouseButton(0))
        {
            if (curtime >= module[weapon].atkSpeed)
            {
                for(int i = 0; i <= 8; i++)
                {
                    GameObject bullet = Instantiate(rifleBullet, bulletTransform);
                    bullet.transform.Rotate(0, 0, Random.Range(-module[weapon].bulletSpread , module[weapon].bulletSpread));
                    bullet.GetComponent<BulletMove>().bulletSpeed = Random.Range(5, 10);
                    bullet.transform.SetParent(null);
                }
                    curtime = 0;
            }
        }
    }
}
