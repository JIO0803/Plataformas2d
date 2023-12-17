using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desbloqueable1 : MonoBehaviour
{
    public GameObject Obstaculo;
    public GameObject Obstaculo2;
    public GameObject Obstaculo3;
    public GameObject Obstaculo4;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            Obstaculo.SetActive(false);
        }

        if (collission.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Obstaculo2.SetActive(false);
        }        
        
        if (collission.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Obstaculo3.SetActive(false);
        }        
        
        if (collission.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Obstaculo4.SetActive(true);
        }
    }
}