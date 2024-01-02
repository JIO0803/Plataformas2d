using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaenemigo : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public int currentHealth;
    private Rigidbody2D rb;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void TakeDamage()
    {
        currentHealth -= 50;

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
        gameObject.GetComponent<vidaenemigo>().enabled = false;

        if(currentHealth <= 0)
        {
            gameObject.GetComponent<Muerte1>().enabled = false;
        }
    }   
}
    