using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarpared : MonoBehaviour
{
    public GameObject Muro;
    public GameObject Cañon;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Plataformas>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Muro.GetComponent<Plataformas>().enabled = true;
        Cañon.SetActive(true);
    }  
}
