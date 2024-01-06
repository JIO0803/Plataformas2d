using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{
    public float vidaPersActual = 3f;
    public Animator animator;

    public Image H1;
    public Image H2;
    public Image H3;
    public float delayTime = 1.5f;

    public float attackRate = 1f;
    float nextAttackTime = 0f;
    public float empuje = 10;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo") && (Time.time >= nextAttackTime))
        {
            animator.SetTrigger("Dañado");
            vidaPersActual -= 1;
            if (gameObject.transform.localScale == new Vector3(1, transform.localScale.y))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * empuje, ForceMode2D.Impulse);
            }
            if (gameObject.transform.localScale == new Vector3(-1, transform.localScale.y))
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * empuje, ForceMode2D.Impulse);
            }
            if (Time.time >= nextAttackTime)
            {
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampas") || collision.gameObject.CompareTag("Muro"))
        {
            animator.SetBool("Muerte", true);
            animator.SetBool("Isjumping", false);
            H1.enabled = false;
            H2.enabled = false;
            H3.enabled = false;
            gameObject.GetComponent<Movjugador>().enabled = false;
            gameObject.GetComponent<vidas>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Invoke("Muere", delayTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trampas") || collision.gameObject.CompareTag("Muro"))
        {
            animator.SetBool("Muerte", true);
            animator.SetBool("Isjumping", false);
            H1.enabled = false;
            H2.enabled = false;
            H3.enabled = false;
            gameObject.GetComponent<Movjugador>().enabled = false;
            gameObject.GetComponent<vidas>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Invoke("Muere", delayTime);
        }
    }

    void Update()
    {
        if (vidaPersActual >= 3f)
        {
            vidaPersActual = 3f;
            H1.enabled = true;
            H2.enabled = true;
            H3.enabled = true;
        }

        if (vidaPersActual >= 2f && vidaPersActual < 3f)
        {
            vidaPersActual = 2f;
            H1.enabled = true;
            H2.enabled = true;
            H3.enabled = false;
        }

        if (vidaPersActual >= 1f && vidaPersActual < 2f)
        {
            vidaPersActual = 1f;
            H1.enabled = true;
            H2.enabled = false;
            H3.enabled = false;
        }

        if (vidaPersActual <= 0)
        {
            animator.SetBool("Muerte", true);
            animator.SetBool("Isjumping", false);
            H1.enabled = false;
            H2.enabled = false;
            H3.enabled = false;
            gameObject.GetComponent<Movjugador>().enabled = false;
            gameObject.GetComponent<vidas>().enabled = false;
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Invoke("Muere", delayTime);
        }
    }

    void Muere()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}