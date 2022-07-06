using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    Vector3 playerDir = Vector3.zero;

    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        var dir = new Vector3(h, v, 0).normalized;

        playerDir += dir * speed * Time.deltaTime;

        playerDir.x = Mathf.Clamp(playerDir.x, -8.5f, 8.5f);
        playerDir.y = Mathf.Clamp(playerDir.y, -4.5f, 4.5f);

        transform.position = playerDir;
    }
}
