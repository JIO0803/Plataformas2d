using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar2 : MonoBehaviour
{
    public GameObject Muro;

    private void Start()
    {
        GetComponent<Seguimiento>();  
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Muro.GetComponent<Seguimiento>().enabled = true;
        }
    }
}
