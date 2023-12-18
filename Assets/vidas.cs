using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidas : MonoBehaviour
{
    public float vidaPersActual;
    public float vidaMax = 100f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        vidaPersActual = vidaMax;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            animator.SetTrigger("Dañado");
            vidaPersActual -= 50;
        }
    }

    void Update()
    {
        if (vidaPersActual <= 0)
        {
            Muere();
        }
        // Update is called once per frame

        void Muere()
        {
            animator.SetBool("Muerte", true);
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
}