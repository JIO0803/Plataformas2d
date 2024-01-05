using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarParallex : MonoBehaviour
{
    public GameObject Fondo1;
    public GameObject Fondo2;
    public GameObject Fondo3;
    public GameObject Fondo4;
    public GameObject Fondo5;
    public GameObject Fondo6;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Parallex>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Fondo1.GetComponent<Parallex>().enabled = true;
        Fondo2.GetComponent<Parallex>().enabled = true;
        Fondo3.GetComponent<Parallex>().enabled = true;
        Fondo4.GetComponent<Parallex>().enabled = true;
        Fondo5.GetComponent<Parallex>().enabled = true;
        Fondo6.GetComponent<Parallex>().enabled = true;
        Destroy(gameObject);
    }
}
