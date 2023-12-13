using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desbloqueable : MonoBehaviour
{
    public BoxCollider2D colision;
    public GameObject Obstaculo;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Obstaculo.SetActive(false);
        }
    }
}