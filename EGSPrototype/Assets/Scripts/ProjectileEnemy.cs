using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : Enemy
{
    
    [SerializeField] float radius;
    [SerializeField] Transform pointer;
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = (playerTransform.position - transform.position);
        Vector3 dir = diff.normalized;
        float sqMag = diff.sqrMagnitude;
        
        pointer.position = transform.position + dir * radius;
        
        if (sqMag < radius * radius)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
    }
}
