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
        //Vector3 gravity = CustomGravity.GetGravity(body.position, out upAxis);
        moveTowardsPlayer();
    }

    void moveTowardsPlayer()
    {
        {
            transform.LookAt(playerTransform);

            if (Vector3.Distance(transform.position, playerTransform.position) >= minAgroDist)
            {

                transform.position += transform.forward * movespeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, playerTransform.position) <= maxAgoDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

            }
        }
    }
}
