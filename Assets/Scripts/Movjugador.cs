using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.XR;

public class Movjugador : MonoBehaviour
{
    // RECORDATORIO!! Te falta hacer que el pibe solo salte con el suelo y no con la pared (haciendo más pequeño por los lados el collider) 
    public bool grounded;
    public float Velocidad = 5f;
    public float salto;
    private Rigidbody2D rb;
    public int saltos = 1;
    public float doublejump;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        float rightInput = Input.GetAxis("Right");
        rb.velocity = new Vector2(rightInput * Velocidad, rb.velocity.y);

        float leftInput = Input.GetAxis("Left");
        rb.velocity = new Vector2(leftInput * Velocidad, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector2(14.59804f, transform.localScale.y);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector2(-14.59804f, transform.localScale.y);
        }

        float speed = Mathf.Abs(rb.velocity.x);

        animator.SetFloat("Speed", speed); 

        if (Input.GetButtonDown("Jump") && grounded)
        {
            animator.SetBool("Isjumping", true);
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


    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
        {
            grounded = true;
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
        {
            grounded = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
        {
            grounded = false;
        }
    }
    void OnCollisionEnter2D(Collision2D col)           
    {
        if (col.gameObject.tag == "plataforma") 
        {
            transform.parent = col.transform;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "plataforma")
        {
            transform.parent = null;
        }
    }
        
}
