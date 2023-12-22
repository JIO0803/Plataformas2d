using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bloqueo : MonoBehaviour
{
    public GameObject puerta;
    public GameObject Obstaculo;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player") 
        {
            puerta.GetComponent<Plataformas1>().enabled = true;
            Obstaculo.GetComponent<Plataformas>().enabled = true;
        }
    }
}