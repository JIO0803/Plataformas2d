using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bloqueo : MonoBehaviour
{
    public BoxCollider2D colision;
    public GameObject Obstaculo;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player") 
        {
            Obstaculo.SetActive(true);
        }
    }
}