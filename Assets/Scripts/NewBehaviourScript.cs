using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool Grounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Grounded = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Grounded = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
