using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desbloqueable : MonoBehaviour
{
    public BoxCollider2D colision;
    public void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.tag == "Player") 
        {
            Destroy(gameObject);
            colision.enabled = false;
        }
    }
}