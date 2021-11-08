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
        float mag = diff.magnitude;

        float sqMag = diff.sqrMagnitude;

        Vector3 dir = diff.normalized;
        pointer.position = transform.position + dir * radius;
        
        if (sqMag < radius * radius)
        {
            Shoot();
            // SAME EXACT THING BUT WITOUT SQ ROOT
        }
    }

    void Shoot()
    {
        
    }
}
