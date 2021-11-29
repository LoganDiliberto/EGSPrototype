using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    
    public Transform attackPointClose;
    public Transform attackPointFar;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int damage = 100;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
            Debug.Log("Attacking");
        }
    }

    void Attack()
    {
        //Play animation
        //Detect enemies in range
        //Damage them
        Collider[] hitEnemies = Physics.OverlapSphere(attackPointClose.position, attackRange, enemyLayers);
        
        //Damage them
        foreach (Collider enemy in hitEnemies)
        {
            GameObject enemyThatIHit = enemy.gameObject;
            Enemy e = enemyThatIHit.GetComponent<Enemy>();
            e.receiveDamage(damage);
            Debug.Log("Enemy Takes damage");
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPointClose == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPointClose.position, attackRange);
    }
}
