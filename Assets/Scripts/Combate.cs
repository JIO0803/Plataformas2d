using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combate : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;

    public float attackRate = 1f;
    float nextAttackTime = 0f;

    public float empuje = 10;
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Ataque");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<vidaenemigo>().TakeDamage();
            if (gameObject.transform.localScale == new Vector3(1, transform.localScale.y))
            {
                enemy.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * empuje, ForceMode2D.Impulse);
            }
            if (gameObject.transform.localScale == new Vector3(-1, transform.localScale.y))
            {
                enemy.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * empuje, ForceMode2D.Impulse);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
