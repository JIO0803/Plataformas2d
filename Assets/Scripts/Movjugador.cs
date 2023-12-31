using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.XR;

public class Movjugador : MonoBehaviour
{
    // RECORDATORIO!! Te falta hacer que el pibe solo salte con el suelo y no con la pared (haciendo m�s peque�o por los lados el collider) 
    public bool grounded;
    public float Velocidad = 5f;
    public float salto;
    private Rigidbody2D rb;
    public int saltos = 1;
    public float doublejump;
    public Animator animator;
    public float altura = 50f;
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
        animator.SetFloat("Speed", Mathf.Abs(rightInput));

        float leftInput = Input.GetAxis("Left");
        rb.velocity = new Vector2(leftInput * Velocidad, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(leftInput));   

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector2(1, transform.localScale.y);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
       
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Isjumping", true);
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetBool("Isjumping", false);
                animator.SetTrigger("Ataque");
            }
            if (Input.GetButtonDown("Jump") && grounded)
            {
                rb.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
            }
            if (Input.GetButtonDown("Jump") && saltos == 1)
            {
                rb.AddForce(Vector2.up * salto * doublejump, ForceMode2D.Impulse);
                saltos = 0;
            }
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
            animator.SetBool("Isjumping", false);
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
        {
            grounded = true;
            animator.SetBool("Isjumping", false);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.isTrigger == false)
        {
            grounded = false;
            animator.SetBool("Isjumping", true);
        }
    }
}
