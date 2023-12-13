using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Movjugador : MonoBehaviour
{
    // RECORDATORIO!! Te falta hacer que el pibe solo salte con el suelo y no con la pared (haciendo más pequeño por los lados el collider) 
    public bool grounded;
    public float Velocidad;
    public float salto;
    Rigidbody2D rb;
    public int saltos = 1;
    public float doublejump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontal, 0, 0) * Velocidad * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("Jump") && saltos == 1)
        {
            rb.AddForce(Vector2.up * salto * doublejump, ForceMode2D.Impulse);
            saltos = 0;
        }
        if (grounded) 
        {
            saltos += 1;
           
            if (saltos >= 1)
            {
                saltos = 1;
            }
            if (saltos <= 0)
            {
                saltos = 0;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        grounded = true;
    } 
    public void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            transform.parent = col.transform;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "platform")
        {
            col.transform.parent = null;
        }
    }
}
