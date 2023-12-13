using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desbloqueable1 : MonoBehaviour
{
    public BoxCollider2D colision;
    public GameObject Obstaculo;
    public GameObject Obstaculo2;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            Obstaculo.SetActive(false);
            Obstaculo2.SetActive(false);

        }
    }
}