using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }
}
