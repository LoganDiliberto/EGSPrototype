using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        moveTowardsPlayer();
    }

    void moveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, movespeed);
    }
}
