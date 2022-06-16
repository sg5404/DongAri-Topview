using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    private float curDelay = 0f;

    private PlayerData playerData = null;
    private PlayerAttack playerAttack = null;

    private List<GameObject> enemyObject;

    private void Awake()
    {
        playerData = GetComponent<PlayerData>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    public void Lambo()
    {
        Debug.Log("LamboMode On");

        playerAttack.module[playerAttack.weapon].isInfiniteBullet = true;
        while(curDelay <= 15f)
        {
            playerData.Atk_Speed += (playerData.Atk_Speed * 0.3f);
            curDelay += Time.deltaTime;
        }
        
    }

    public void MadangSslGi()
    {
        Debug.Log("MadanSslgi On");

        enemyObject = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));

        foreach(var enemyItem in enemyObject)
        {
            if(Vector3.Distance(enemyItem.transform.position, transform.position) <= 4f)
            {

            }
        }

        playerAttack.module[playerAttack.weapon].magazine = 8;
    }

}
