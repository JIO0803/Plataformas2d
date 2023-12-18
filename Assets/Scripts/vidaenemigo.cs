using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaenemigo : MonoBehaviour
{
    public Animator animator;
    private int maxHealth = 100;
    int currentHealth;
    public GameObject enemigo;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Muere();
        }

    }

    

    void Muere()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("IsDead", true);

        gameObject.GetComponent<IA>().enabled = false;   
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
        gameObject.GetComponent<vidaenemigo>().enabled = true;

        if(currentHealth <= 0)
        {
            gameObject.GetComponent<Muerte1>().enabled = false;
        }
    }   

}
    