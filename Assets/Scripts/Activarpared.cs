using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarpared : MonoBehaviour
{
    public GameObject Muro;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Plataformas>();
        GetComponent<Plataformas1>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        Muro.GetComponent<Plataformas>().enabled = true;
        Muro.GetComponent<Plataformas1>().enabled = true;
        Destroy(gameObject);
    }  
}
