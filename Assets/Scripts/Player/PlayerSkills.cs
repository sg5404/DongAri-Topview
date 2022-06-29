using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    private float curDelay = 0f;

    private PlayerData playerData = null;
    private PlayerAttack playerAttack = null;

    private List<GameObject> enemyObject;

    private Rigidbody2D rb = null;

    private void Awake()
    {
        playerData = GetComponent<PlayerData>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    public void Lambo()
    {
        Debug.Log("LamboMode On");

        playerAttack.module[playerAttack.weapon].isInfiniteBullet = true;
        while (curDelay <= 15f)
        {
            playerData.Atk_Speed += (playerData.Atk_Speed * 0.3f);
            curDelay += Time.deltaTime;
        }

    }

    public void MadangSslGi()
    {
        Debug.Log("MadanSslgi On");

        enemyObject = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));

        foreach (GameObject enemyItem in enemyObject)
        {
            if (Vector3.Distance(transform.position, enemyItem.transform.position) <= 2f)
            {
                rb = enemyItem.GetComponent<Rigidbody2D>();
                Vector3 reactVec = enemyItem.transform.position - transform.position;
                reactVec = reactVec.normalized;
                enemyItem.transform.position += reactVec * 5;
                //rb.velocity = reactVec * 10;
                rb.AddForce(reactVec * 5, ForceMode2D.Impulse);
                Debug.Log(reactVec);
                Debug.Log("³Ë¹é");
            }

        }

        playerAttack.module[playerAttack.weapon].magazine = 8;
    }
}
