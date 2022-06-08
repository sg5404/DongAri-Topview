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

    void Start()
    {
        weaponSet = GetComponent<WeaponSet>();
        StartCoroutine(Fire());
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        var direction = mousePosition - bulletTransform.position;

        var rotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        bulletTransform.rotation = Quaternion.Euler(0, 0, rotation);
    }

    IEnumerator Fire()
    {
        while (true)
        {
            if (Input.GetMouseButton(0))
            {
                switch (weaponSet.SubWeaponState) // ÃÑ¾Ë¹ß»ç °¡´ÉÇÏ°Ô²û ÇÏ±â
                {
                    case WeaponKind.SWORD:
                        break;
                    case WeaponKind.RIFLE:
                        GameObject bullet = Instantiate(rifleBullet, bulletTransform);
                        bullet.transform.SetParent(null);
                        break;
                    case WeaponKind.SNIPER:
                        break;
                    case WeaponKind.SHOTGUN:
                        break;
                    case WeaponKind.GRANADE:
                        break;
                }
            }
                yield return new WaitForSeconds(0.1f);
        }
    }
}
