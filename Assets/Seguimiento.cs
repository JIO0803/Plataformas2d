using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public GameObject Seguir;
    void Update()
    {
        gameObject.transform.position = Seguir.transform.position + gameObject.transform.position;
    }
}
