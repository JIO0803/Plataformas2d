using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bloqueo : MonoBehaviour
{
    public GameObject puerta;
    public GameObject Obstaculo;
    public Animator animator;
    public int maxHealth = 50;
    public int currentHealth;
    public GameObject player;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage()
    {
        currentHealth -= 50;

        animator.SetTrigger("Activado");

        if (currentHealth <= 0)
        {
            Activado();
        }
    }

    void Activado()
    {
        puerta.GetComponent<Plataformas1>().enabled = true;
        Obstaculo.GetComponent<Plataformas>().enabled = true;
    }
}