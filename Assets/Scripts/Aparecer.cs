using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Aparecer : MonoBehaviour
{
    public GameObject Activo;
    public GameObject Inactivo;
    public GameObject Inactivo1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Inactivo.SetActive(false);
            Inactivo1.SetActive(false);
            Activo.SetActive(true);
        }
    }
}
